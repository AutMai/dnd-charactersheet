using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ItemRepository : ARepository<Item>, IItemRepository{
    public ItemRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }

    public async Task<Item?> ReadAsync(string name) {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var set = context.Set<Item>();
        return await set.FirstOrDefaultAsync(i => i.Name == name);
    }
}