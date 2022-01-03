using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class BackgroundRepository:ARepository<Background>{
    public BackgroundRepository(IDbContextFactory<CharacterSheetDbContext> contextFactory) : base(contextFactory){
    }
}