using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ClassRepository : ARepository<Class>, IClassRepository {
    public ClassRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Class> ReadGraphAsync(int id) => (await _set
        .SingleOrDefaultAsync(c => c.ClassId == id))!;

    public async Task<Class> ReadGraphAsync(string name) => (await _set
        .SingleOrDefaultAsync(c => c.Name == name))!;

    public async Task<List<Class>> ReadGraphAsync() => (await _set
        .ToListAsync());
}