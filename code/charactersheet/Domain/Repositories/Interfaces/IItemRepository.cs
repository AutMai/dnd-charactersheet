using Model.Entities;

namespace Domain.Repositories.Interfaces;

public interface IItemRepository : IRepository<Item>{
   Item? Read (string name);      
}