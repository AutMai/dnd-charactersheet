using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class AbilityNameRepository : ARepository<EAbilityName>, IAbilityNameRepository {
    public AbilityNameRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
    
    public async Task<List<EAbilityName>> ReadGraphAsync() {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<EAbilityName>();
        return await set
            .Include(a => a.SkillNames).ToListAsync();
    } 

 
}