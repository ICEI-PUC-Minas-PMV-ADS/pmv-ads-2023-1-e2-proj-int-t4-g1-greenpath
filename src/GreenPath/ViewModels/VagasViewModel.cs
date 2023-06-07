using GreenPath.Models;

public class VagasViewModel
{
    public VagasModel? Vaga { get; set; }
    public IQueryable<PessoaFisicaModel>? Candidatos { get; set; }
    public bool Inscrito { get; set; } 
}