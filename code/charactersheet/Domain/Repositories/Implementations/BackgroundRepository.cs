using Domain.Repositories.Interfaces;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class BackgroundRepository : ARepository<Background> {
    public BackgroundRepository(CharacterSheetDbContext context) : base(context) {
    }
}