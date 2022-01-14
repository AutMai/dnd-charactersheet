using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IApplicationUserRepository : IRepository<ApplicationUser> {
    public Task<ApplicationUser?> ReadGraphAsync(string name);
    public Task<ApplicationUser?> ReadAsync(string name);
}