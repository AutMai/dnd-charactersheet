﻿using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ClassRepository : ARepository<Class>, IClassRepository {
    public ClassRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }

    public async Task<Class> ReadGraphAsync(string name) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Class>();
        return await set
            .Include(c => c.ClassHasSkillProficienciesChoices)
            .Include(c => c.AbilityNames)
            .Include(c => c.ArmorTypes)
            .Include(c => c.Features)
            .Include(c => c.Spells)
            .Include(c => c.WeaponTypes)
            .SingleOrDefaultAsync(c => c.Name == name) ?? new Class();
    }

    public async Task<List<Class>> ReadGraphAsync() {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Class>();
        return await set.Include(c => c.AbilityNames).ToListAsync();
    }
}