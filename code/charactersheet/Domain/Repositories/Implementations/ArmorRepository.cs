using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ArmorRepository : ARepository<Armor>{
    public ArmorRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory){
    }
}