using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;
using Model.Identity;

namespace Domain.Repositories.Implementations;

public class ApplicationUserRepository : ARepository<ApplicationUser>, IApplicationUserRepository {
    public ApplicationUserRepository(CharacterSheetDbContext context) : base(context) {
    }

    public async Task<ApplicationUser?> ReadGraphAsync(string name) => await _set.SingleOrDefaultAsync(k => k.UserName == name);

    public async Task<ApplicationUser?> ReadAsync(string name)  => await _set.SingleOrDefaultAsync(k => k.UserName == name);
}