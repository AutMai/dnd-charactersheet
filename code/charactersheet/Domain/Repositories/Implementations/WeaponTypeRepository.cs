using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class WeaponTypeRepository : ARepository<EWeaponType> {
    public WeaponTypeRepository(CharacterSheetDbContext context) : base(context) {
    }
}