using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Core.Entities;
using TechMed.Core.Exceptions;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services;
public class AtendimentoService : BaseService, IAtendimentoService
{  
   private readonly IMedicoService _medicoService;
   public AtendimentoService(ITechMedContext context, IMedicoService medico) : base(context)
   {
      _medicoService = medico;
   }
   public int Create(NewAtendimentoInputModel atendimento){
      return _medicoService.CreateAtendimento(atendimento.MedicoId, atendimento);
   }

   public int CreateExame(NewExameInputModel exame){
      return _context.ExameCollection.Create(new Exame{
         DataHora = exame.DataHora,
         NomeExame = exame.NomeExame,
         IdAtendimento = exame.IdAtendimento
      });
   }

   /*  public int CreateExame(NewAtendimentoInputModel atendimento)
    {
        throw new NotImplementedException();
    } */

    public List<AtendimentoViewModel> GetAll()
   {
      return _context.AtendimentosCollection.GetAll().Select(a => new AtendimentoViewModel
      {
         AtendimentoId = a.AtendimentoId,
         DataHora = a.DataHora,
         Medico = new MedicoViewModel
         {
            MedicoId = a.Medico.MedicoId,
            Nome = a.Medico.Nome
         },
         Paciente = new PacienteViewModel
         {
            PacienteId = a.Paciente.PacienteId,
            Nome = a.Paciente.Nome
         }
      }).ToList();
   }

   public List<AtendimentoViewModel> GetByMedicoId(int medicoId)
   {
      throw new NotImplementedException();
   }

   public List<AtendimentoViewModel> GetByPacienteId(int pacienteId)
   {
      throw new NotImplementedException();
   }
}
