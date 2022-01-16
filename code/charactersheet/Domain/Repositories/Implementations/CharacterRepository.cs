using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository {
    public CharacterRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Character> ReadGraphAsync(string name) =>
        await _set.FirstOrDefaultAsync(c => c.Name == name) ?? new Character();

    public async Task<Character> ReadGraphAsync(int id) => (await _set.SingleOrDefaultAsync(c => c.CharacterId == id))!;

    public new async Task<Character> CreateAsync(Character character) {
        //_context.ChangeTracker.Clear();
        _context.Attach(character.Background);
        _context.Attach(character.Race);
        _context.Attach(character.Class);
        _set.Add(character);
        await _context.SaveChangesAsync();
        return character;
    }
}