using Microsoft.AspNetCore.Mvc;
using GreenPath.Data;

namespace GreenPath.Controllers;

public class ProcessoController : Controller
{

    private readonly BancoContexto _context;
    public ProcessoController(BancoContexto contexto)
    {
        _context = contexto;
    }

    public Task<IActionResult> Index()
    {
        string userId = Global.CurrentUser.Id;

        var vagas = from inscricoes in _context.Inscricoes where inscricoes.PessoaId == userId join vaga in _context.Vagas on inscricoes.VagaId equals vaga.Id select vaga;
      
        ProcessoViewModel viewModel = new ProcessoViewModel{
            Vagas = vagas
        };

        return Task.FromResult<IActionResult>(View(viewModel));
    }
}
