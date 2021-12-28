using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class AbilityNameRepository:ARepository<EAbilityName> {
    public AbilityNameRepository(CharacterSheetDbContext context) : base(context) {
    }
}