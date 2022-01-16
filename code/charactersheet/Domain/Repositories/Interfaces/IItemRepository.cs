using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IItemRepository : IRepository<Item>{
   Task<Item?> ReadAsync(string name);      
}