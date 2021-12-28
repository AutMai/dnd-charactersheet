using Domain.Extensions;
using Domain.Repositories.Interfaces;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class CharacterRepository : ARepository<Character>, ICharacterRepository{
    public CharacterRepository(CharacterSheetDbContext context) : base(context){
    }

    public Character GetByName(string name){
        return _set.FirstOrDefault(c => c.Name == name)!;
    }


    public Character? GetGraph(int id){
        return _set.IncludeAll().FirstOrDefault(k => k.CharacterId == id);
    }
}