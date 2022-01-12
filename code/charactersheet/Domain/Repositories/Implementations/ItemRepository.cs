using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class ItemRepository:ARepository<Item> {
    public ItemRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
}