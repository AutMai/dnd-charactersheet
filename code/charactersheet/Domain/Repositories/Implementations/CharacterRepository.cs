using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository {
    public CharacterRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Character> ReadGraphAsync(string name) => (await _set.IncludeAll().FirstOrDefaultAsync(c => c.Name == name))!;
    
    public async Task<Character> ReadGraphAsync(int id) =>
        (await _set.IncludeAll().SingleOrDefaultAsync(k => k.CharacterId == id))!;
}