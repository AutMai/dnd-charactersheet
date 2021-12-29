using Model.Entities;

namespace Domain.Repositories.Interfaces; 

public interface IAbilityNameRepository:IRepository<EAbilityName>  {
    Task<List<EAbilityName>> ReadGraphAsync();
}