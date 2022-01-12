using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ApplicationUserRepository : ARepository<ApplicationUser>, IApplicationUserRepository{

    public async Task<ApplicationUser?> ReadGraphAsync(string name){
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<ApplicationUser>();
        return await set.IncludeAll().SingleOrDefaultAsync(k => k.UserName == name);
    }

    public async Task<ApplicationUser?> ReadAsync(string name){
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<ApplicationUser>();
        return await set.Include(a => a.Characters).SingleOrDefaultAsync(k => k.UserName == name);
    }

    public ApplicationUserRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
}