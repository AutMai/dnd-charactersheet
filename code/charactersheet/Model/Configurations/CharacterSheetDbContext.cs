using Microsoft.EntityFrameworkCore;

namespace Model.Configurations;

public class CharacterSheetDbContext : DbContext {
    public CharacterSheetDbContext(DbContextOptions<CharacterSheetDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder builder) {
    }
}