using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface IRaceRepository :IRepository<Race> {
    Task<Race> ReadGraphAsync(int id);
    Task<Race> ReadGraphAsync(string name);
    Task<List<Race>> ReadParentRaces();
}