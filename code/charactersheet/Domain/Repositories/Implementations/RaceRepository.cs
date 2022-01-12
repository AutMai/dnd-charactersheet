using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class RaceRepository : ARepository<Race>, IRaceRepository{

    public async Task<Race> ReadGraphAsync(int id) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Race>();
        return await set
            .Include(r => r.RaceHasAbilityScoreIncreases)
            .Include(r => r.ParentRace)
            .Include(r => r.Traits)
            .Include(r => r.LanguageNames)
            .Include(r => r.SubRaces)
            .ThenInclude(sr => sr.Traits)
            .SingleOrDefaultAsync(r => r.RaceId == id) ?? new Race();
    } 

    public async Task<Race> ReadGraphAsync(string name) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Race>();
        return await set
            .Include(r=>r.RaceHasAbilityScoreIncreases)
            .Include(r => r.ParentRace)
            .Include(r => r.Traits)
            .Include(r => r.LanguageNames)
            .Include(r => r.SubRaces)
            .ThenInclude(sr => sr.Traits)
            .SingleOrDefaultAsync(r => r.Name == name) ?? new Race();
    } 

    public async Task<List<Race>> ReadGraphAsync() {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Race>();
        return await set.Include(r => r.RaceHasAbilityScoreIncreases).ToListAsync();
    } 

    public async Task<List<Race>> ReadParentRaces() =>
        (await ReadAsync()).Where(k => k.ParentRace is null).ToList();

    public RaceRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
}