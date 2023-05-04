using GreenPath.Data;
using GreenPath.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenPath.Controllers;

public class ProfileController : Controller
{

    private readonly BancoContexto _context;
    public ProfileController(BancoContexto contexto)
    {
        _context = contexto;
    }

    public async Task<GreenPath.Models.PessoaFisicaModel> GetPersonById(int id)
    {
        var person = await _context.PessoaFisica.FindAsync(id);

        return person;
    }

    public async Task<IActionResult> Index()
    {
        int id = 1;
        var person = await GetPersonById(id);

        if (person == null)
        {
            return NotFound("Nao foi possivel encontrar a Pessoa Fisica com id: " + id);
        }

        return View(person);
    }
}
