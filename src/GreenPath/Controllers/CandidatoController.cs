using Microsoft.AspNetCore.Mvc;
using GreenPath.Data;
using GreenPath.Models;

namespace GreenPath.Controllers;

public class CandidatoController : Controller
{

    private readonly BancoContexto _context;
    public CandidatoController(BancoContexto contexto)
    {
        _context = contexto;
    }

    public async Task<IActionResult> Index()
    {
        string id = (string)RouteData.Values["id"];

        PessoaFisicaModel userData = await _context.PessoaFisica.FindAsync(id);

        if (userData == null) return NotFound("Usuário não encontrado");
        else
        {
            var viewModel = new CandidatoViewModel
            {
                Candidato = userData
            };

            return View(viewModel);
        }
    }
}
