namespace TechMed.Core.Entities;

public class Exame : BaseEntity
{
    public int ExameId { get; set; }
    public DateTime DataHora { get; set; }
   // public PacienteViewModel Paciente { get; set; } = null!;
    //public MedicoViewModel Medico { get; set; } = null!;
    public string? NomeExame{get; set;}
    public int IdAtendimento {get;  set;}
}
