using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface ICharacterRepository:IRepository<Character> {
    public Task<Character> GetByName(string name);
    public Task<Character> GetGraph(int id);
}