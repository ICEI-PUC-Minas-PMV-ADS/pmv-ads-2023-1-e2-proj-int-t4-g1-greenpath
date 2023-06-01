using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreenPath.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
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

        if (userData == null && companyData == null) return NotFound("Usuário não encontrado");
        else if (userData == null)
        {
            var viewModel = new UserProfileViewModel
            {
                EmpresaData = companyData,
                PessoaFisicaData = null
            };
            return View(viewModel);
        }
        else
        {
            var viewModel = new UserProfileViewModel
            {
                EmpresaData = null,
                PessoaFisicaData = userData
            };
            return View(viewModel);
        }
    }
}
