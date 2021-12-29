using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class SkillNameRepository:ARepository<ESkillName> {
    public SkillNameRepository(CharacterSheetDbContext context) : base(context) {
    }
}