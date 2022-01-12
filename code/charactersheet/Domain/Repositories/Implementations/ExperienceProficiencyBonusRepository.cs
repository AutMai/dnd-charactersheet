using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations; 

public class ExperienceProficiencyBonusRepository:ARepository<ExperienceProficencyBonu> {
    public ExperienceProficiencyBonusRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory) {
    }
}