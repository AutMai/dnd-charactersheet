using Domain.Repositories.Interfaces;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ItemRepository : ARepository<Item>, IItemRepository{
    public ItemRepository(CharacterSheetDbContext context) : base(context) {
    }

    public Item? Read(string name) {
        return _set.FirstOrDefault(i => i.Name == name);
    }
}