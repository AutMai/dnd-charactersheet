﻿using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class RaceRepository : ARepository<Race>, IRaceRepository{
    public RaceRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory){
    }

    public async Task<Race> ReadGraphAsync(int id) => (await _set
        .Include(r=>r.RaceHasAbilityScoreIncreases)
        .Include(r => r.ParentRace)
        .Include(r => r.Traits)
        .Include(r => r.LanguageNames)
        .Include(r => r.SubRaces)
        .ThenInclude(sr => sr.Traits)
        .SingleOrDefaultAsync(r => r.RaceId == id))!;

    public async Task<Race> ReadGraphAsync(string name) => (await _set
        .Include(r=>r.RaceHasAbilityScoreIncreases)
        .Include(r => r.ParentRace)
        .Include(r => r.Traits)
        .Include(r => r.LanguageNames)
        .Include(r => r.SubRaces)
        .ThenInclude(sr => sr.Traits)
        .SingleOrDefaultAsync(r => r.Name == name))!;

    public async Task<List<Race>> ReadParentRaces() =>
        (await ReadAsync()).Where(k => k.ParentRace is null).ToList();
}