using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterHasItemsRepository : ARepository<CharactersHasItem> {
    public CharacterHasItemsRepository(CharacterSheetDbContext context) : base(context) {
    }
}