using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ArmorTypeRepository : ARepository<EArmorType>{
    public ArmorTypeRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory){
    }
}