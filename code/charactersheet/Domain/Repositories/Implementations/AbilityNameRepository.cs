using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class AbilityNameRepository:ARepository<EAbilityName>, IAbilityNameRepository {
    public AbilityNameRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<List<EAbilityName>> ReadGraphAsync() => await _set
        .Include(a => a.SkillNames).ToListAsync();
}