using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository {
    public CharacterRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }

    public async Task<Character> ReadGraphAsync(string name) => (await _set.IncludeAll().FirstOrDefaultAsync(c => c.Name == name))!;
    
   /* public async Task<Character> ReadGraphAsync(int id) =>
        (await _set.IncludeAll().SingleOrDefaultAsync(k => k.CharacterId == id))!;*/

   public async Task<Character> ReadGraphAsync(int id) => (await _set
       .Include(c => c.Abilities)
       .ThenInclude(a=>a.Skills)
       .Include(c => c.Class)
       .ThenInclude(c => c.Features)
       .Include(c => c.Race)
       .ThenInclude(r => r.Traits)
       .Include(c => c.Background)
       .Include(c => c.Spells)
       .Include(c => c.Personalities)
       .Include(c => c.Names)
       .Include(c => c.DeathSafe)
       .Include(c => c.CharactersHasItems)
       .ThenInclude(i => i.Item)
       .SingleOrDefaultAsync(c => c.CharacterId == id))!;
}