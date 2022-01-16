using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository {

    public async Task<Character> ReadGraphAsync(string name) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Character>();
        return await set.IncludeAll().FirstOrDefaultAsync(c => c.Name == name) ?? new Character();
    } 
   public async Task<Character> ReadGraphAsync(int id) {
       await using var context = await _contextFactory.CreateDbContextAsync();
       var set = context.Set<Character>();
       return await set
           .Include(c => c.Abilities)
           .ThenInclude(a => a.Skills)
           .Include(c => c.Class)
           .ThenInclude(c => c.Features)
           .Include(c => c.Race)
           .ThenInclude(r => r.Traits)
           .Include(c => c.Background)
           .Include(c => c.Spells)
           .Include(c => c.Personalities)
           .Include(c => c.Languages)
           .Include(c => c.CharactersHasItems)
           .ThenInclude(i => i.Item)
           .ThenInclude(i => i.Weapon)
           .Include(c => c.CharactersHasItems)
           .ThenInclude(i => i.Item)
           .ThenInclude(i => i.Armor)
           .Include(i => i.ApplicationUser)
           .SingleOrDefaultAsync(c => c.CharacterId == id) ?? new Character();
   } 
   
   public new async Task<Character> CreateAsync(Character character) {
       await using var context = await _contextFactory.CreateDbContextAsync();
       var set = context.Set<Character>();
       
       set.Add(character);
       await context.SaveChangesAsync();
       return character;
   }
   
   public async Task<Character> CreateWithIdsAsync(Character character) {
       await using var context = await _contextFactory.CreateDbContextAsync();
       var set = context.Set<Character>();
       character.BackgroundId = character.Background.BackgroundId;
       character.Background = null;
       character.ClassId = character.Class.ClassId;
       character.Class = null;
       character.RaceId = character.Race.RaceId;
       character.Race = null;
       set.Add(character);
       await context.SaveChangesAsync();
       return character;
   }

   public CharacterRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
   }
}