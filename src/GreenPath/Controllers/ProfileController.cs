using Microsoft.AspNetCore.Mvc;
using GreenPath.Data;
using GreenPath.Models;

namespace GreenPath.Controllers;

public class ProfileController : Controller
{

    private readonly BancoContexto _context;
    public ProfileController(BancoContexto contexto)
    {
        _context = contexto;
    }

    public async Task<IActionResult> Index()
    {
        string id = (string)RouteData.Values["id"];

        PessoaFisicaModel userData = await _context.PessoaFisica.FindAsync(id);
        EmpresaModel companyData = await _context.Empresas.FindAsync(id);

        var certs = from cert in _context.CertificacoesJuri where cert.Emp_Id == id join certDetails in _context.Certificacoes on cert.Cert_Id equals certDetails.id orderby certDetails.titulo select certDetails;

        if (userData == null && companyData == null) return NotFound("Usuário não encontrado");
        else if (userData == null)
        {
            var viewModel = new UserProfileViewModel
            {
                EmpresaData = companyData,
                PessoaFisicaData = null,
                Certificates = certs
            };
            return View(viewModel);
        }
        else
        {
            var viewModel = new UserProfileViewModel
            {
                EmpresaData = null,
                PessoaFisicaData = userData,
                Certificates = null
            };
            return View(viewModel);
        }
    }
}
