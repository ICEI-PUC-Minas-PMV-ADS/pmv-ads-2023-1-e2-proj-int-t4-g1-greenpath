using GreenPath.Models;

public class EmpresaDetailsViewModel
{
    public EmpresaModel? EmpresaData { get; set; }
    public IQueryable<CertificacaoModel>? Certificates { get; set; }
    public IQueryable<VagasModel>? Vagas { get; set; }
}