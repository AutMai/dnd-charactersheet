using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface ICharacterRepository : IRepository<Character>{
    public Character GetByName(string name);
    public Character GetGraph(int id);
}