using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository{
    public CharacterRepository(CharacterSheetDbContext context) : base(context){
    }

    public Character GetByName(string name){
        return _set.FirstOrDefault(c => c.Name == name)!;
    }


    public async Task<Character?> GetGraph(int id){
        return await _set.IncludeAll().SingleOrDefaultAsync(k => k.CharacterId == id);
    }
}