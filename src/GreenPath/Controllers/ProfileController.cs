using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreenPath.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

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
        // var person10 = await GetPersonById(1);

        return View();
    }

    // public async Task<GreenPath.Models.PessoaFisicaModel> GetPersonById(int id)
    // {
    //     var person = await _context.PessoaFisica.FindAsync(id);

    //     return person;
    // }
}
