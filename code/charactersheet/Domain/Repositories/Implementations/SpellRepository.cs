using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class SpellRepository : ARepository<Spell>, ISpellRepository {
    public SpellRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Spell> ReadGraphAsync(string name) => (await _set
        .SingleOrDefaultAsync(s => s.Name == name))!;
}