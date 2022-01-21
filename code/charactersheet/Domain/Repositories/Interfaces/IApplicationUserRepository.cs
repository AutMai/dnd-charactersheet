using Model.Entities;
using Model.Identity;

namespace Domain.Repositories.Interfaces;

public interface IApplicationUserRepository : IRepository<ApplicationUser> {
    public Task<ApplicationUser?> ReadGraphAsync(string name);
    public Task<ApplicationUser?> ReadAsync(string name);
}