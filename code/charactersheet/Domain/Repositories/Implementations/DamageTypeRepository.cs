using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class DamageTypeRepository : ARepository<EDamageType> {
    public DamageTypeRepository(CharacterSheetDbContext context) : base(context) {
    }
}