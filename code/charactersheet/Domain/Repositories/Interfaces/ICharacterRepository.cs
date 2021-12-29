using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface ICharacterRepository:IRepository<Character> {
    public Task<Character> ReadGraphAsync(string name);
    public Task<Character> ReadGraphAsync(int id);
}