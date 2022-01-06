using Domain.Repositories.Implementations;
using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface IRaceRepository :IRepository<Race> {
    Task<Race> ReadGraphAsync(int id);
    Task<Race> ReadGraphAsync(string name);
    Task<List<Race>> ReadGraphAsync();
    Task<List<Race>> ReadParentRaces();
}