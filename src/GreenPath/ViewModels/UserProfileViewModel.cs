using GreenPath.Models;

public class UserProfileViewModel
{
    public PessoaFisicaModel? PessoaFisicaData { get; set; }
    public EmpresaModel? EmpresaData { get; set; }
    public IQueryable<CertificacaoModel>? Certificates { get; set; }
    public IQueryable<VagasModel>? Vagas { get; set; }
    public IFormFile? Image { get; set; }
}
