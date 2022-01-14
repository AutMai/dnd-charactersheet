using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ClassRepository : ARepository<Class>, IClassRepository {
    public ClassRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Class> ReadGraphAsync(int id) => (await _set
        .Include(c => c.ClassHasSkillProficienciesChoices)
        .Include(c => c.AbilityNames)
        .Include(c => c.ArmorTypes)
        .Include(c => c.Features)
        .Include(c => c.Spells)
        .Include(c => c.WeaponTypes)
        .SingleOrDefaultAsync(c => c.ClassId == id))!;

    public async Task<Class> ReadGraphAsync(string name) => (await _set
        .Include(c => c.ClassHasSkillProficienciesChoices)
        .Include(c => c.AbilityNames)
        .Include(c => c.ArmorTypes)
        .Include(c => c.Features)
        .Include(c => c.Spells)
        .Include(c => c.WeaponTypes)
        .SingleOrDefaultAsync(c => c.Name == name))!;

    public async Task<List<Class>> ReadGraphAsync() => (await _set
        .Include(c => c.AbilityNames).ToListAsync());
}