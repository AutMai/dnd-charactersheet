using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class RaceRepository : ARepository<Race>, IRaceRepository {
    public RaceRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<Race> ReadGraphAsync(int id) => (await _set
        .SingleOrDefaultAsync(r => r.RaceId == id))!;

    public async Task<Race> ReadGraphAsync(string name) => (await _set
        .SingleOrDefaultAsync(r => r.Name == name))!;

    public async Task<List<Race>> ReadGraphAsync() =>
        await _set.ToListAsync();

    public async Task<List<Race>> ReadParentRaces() =>
        (await ReadAsync()).Where(k => k.ParentRace is null).ToList();
}