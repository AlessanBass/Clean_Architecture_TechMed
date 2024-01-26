using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Core.Exceptions;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services;
public class ExameService : BaseService, IExameService
{
   private readonly IAtendimentoService _atendimentoService;
   public ExameService(ITechMedContext context, IAtendimentoService atendimento) : base(context)
   {
      _atendimentoService = atendimento;
   }

    public int Create(NewExameInputModel exame){
      return _atendimentoService.CreateExame(exame);
   }

   public List<ExameViewModel> GetAll()
   {
      return _context.ExameCollection.GetAll().Select(a => new ExameViewModel
      {
         IdAtendimento = a.IdAtendimento,
         DataHora = a.DataHora,
         NomeExame = a.NomeExame,
         ExameId = a.ExameId
      }).ToList();
   }


}
