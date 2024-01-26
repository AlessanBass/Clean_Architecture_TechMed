using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;

public class ExameDB : IExameCollection
{
    private readonly List<Exame> _exames = new List<Exame>();
    private int _id = 0; 
    public int Create(Exame exame)
    {
        if(_exames.Count > 0)
         _id = _exames.Max(m => m.IdAtendimento);
      exame.IdAtendimento = ++_id;
      _exames.Add(exame);
      return exame.IdAtendimento;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<Exame> GetAll()
    {
        return _exames.ToArray();
    }

    public Exame? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, Exame obj)
    {
        throw new NotImplementedException();
    }
}
