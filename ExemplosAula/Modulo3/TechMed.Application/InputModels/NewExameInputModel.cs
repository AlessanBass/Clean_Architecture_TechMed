namespace TechMed.Application.InputModels
{
public class NewExameInputModel
{
    public DateTime DataHora { get; set; }
    //public int PacienteId { get; set; }
    //public int MedicoId { get; set; }
    public string? NomeExame{get; set;}
    public int IdAtendimento {get;  set;}
}
}
