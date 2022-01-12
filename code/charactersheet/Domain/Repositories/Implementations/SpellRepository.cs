using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class SpellRepository : ARepository<Spell>, ISpellRepository {


    public async Task<Spell> ReadGraphAsync(string name) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Spell>();
        return await set
            .Include(s => s.Classes)
            .SingleOrDefaultAsync(s => s.Name == name) ?? new Spell();
    } 

    public SpellRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
}