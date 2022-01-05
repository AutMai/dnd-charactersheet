using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ApplicationUserRepository : ARepository<ApplicationUser>, IApplicationUserRepository{
    public ApplicationUserRepository(CharacterSheetDbContext context) : base(context){
    }

    public async Task<ApplicationUser?> ReadGraphAsync(string name){
        return await _set.IncludeAll().SingleOrDefaultAsync(k => k.UserName == name);
    }
}