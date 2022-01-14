using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IClassRepository : IRepository<Class> {
    Task<Class> ReadGraphAsync(int id);
    Task<Class> ReadGraphAsync(string name);
    Task<List<Class>> ReadGraphAsync();
}