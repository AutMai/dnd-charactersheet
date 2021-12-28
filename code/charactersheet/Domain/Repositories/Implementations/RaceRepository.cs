using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class RaceRepository : ARepository<Race>, IRaceRepository {
    public RaceRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Race> ReadGraphAsync(int id) => await _set
        .Include(s => s.ParentRace)
        .Include(s => s.Traits)
        .Include(s=>s.LanguageNames)
        .Include(s=> s.InverseParentRace)
        .SingleOrDefaultAsync(s => s.RaceId == id);
    public async Task<Race> ReadGraphAsync(string name) => await _set
        .Include(s => s.ParentRace)
        .Include(s => s.Traits)
        .Include(s=>s.LanguageNames)
        .Include(s=> s.InverseParentRace)
        .SingleOrDefaultAsync(s => s.Name == name);
}