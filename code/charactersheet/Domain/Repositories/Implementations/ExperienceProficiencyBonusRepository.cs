using Domain.Repositories.Interfaces;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class ExperienceProficiencyBonusRepository:ARepository<ExperienceProficencyBonu> {
    public ExperienceProficiencyBonusRepository(CharacterSheetDbContext context) : base(context) {
    }
}