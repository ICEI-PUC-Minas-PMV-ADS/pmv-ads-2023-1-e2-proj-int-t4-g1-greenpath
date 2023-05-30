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
        var person = await _context.Users.FindAsync("414f02e6-d68f-49b8-9222-baea88375cd4");


        System.Console.WriteLine(person);

        return View();
    }
}
