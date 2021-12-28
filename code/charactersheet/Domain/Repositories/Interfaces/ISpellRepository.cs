using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface ISpellRepository :IRepository<Spell> {
    Task<Spell> ReadGraphAsync(string name);
}