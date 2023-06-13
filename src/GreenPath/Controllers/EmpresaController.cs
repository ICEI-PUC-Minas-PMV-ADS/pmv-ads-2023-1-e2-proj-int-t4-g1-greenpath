using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenPath.Data;
using GreenPath.Models;
using Microsoft.AspNetCore.Authorization;

namespace GreenPath.Controllers
{
	public class EmpresaController : Controller
	{
		private readonly BancoContexto _context;

		public EmpresaController(BancoContexto context)
		{
			_context = context;
		}

		// GET: Empresa
		public async Task<IActionResult> Index(string BuscaString)
		{

			ViewData["Filtro"] = BuscaString;

			var empresas = from emp in _context.Empresas select emp;
			if (!String.IsNullOrEmpty(BuscaString))
			{
				empresas = empresas.Where(emp => (emp.Razao.Contains(BuscaString) || emp.Area.Contains(BuscaString) || emp.Pais.Contains(BuscaString) || emp.Estado.Contains(BuscaString) || emp.Cidade.Contains(BuscaString)));
			}

			return await Task.FromResult(View(empresas));
		}

		// GET: Empresa/Details/5
		public async Task<IActionResult> Details(string? id)
		{
			EmpresaModel companyData = await _context.Empresas.FindAsync(id);

			if (companyData == null)
			{
				return NotFound();
			}

			var certs = from cert in _context.CertificacoesJuri where cert.Emp_Id == id join certDetails in _context.Certificacoes on cert.Cert_Id equals certDetails.id orderby certDetails.titulo select certDetails;

			 var vagas = from vaga in _context.Vagas where vaga.Empresa == id select vaga;

			var viewModel = new EmpresaDetailsViewModel
			{
				EmpresaData = companyData,
				Certificates = certs,
				Vagas = vagas
			};

			return View(viewModel);
		}

		// GET: Empresa/Create
		[Authorize(Roles = "userPJ")]
		public IActionResult Create()
		{
			return View();
		}

		// GET: Empresa/Edit/5
		[Authorize(Roles = "userPJ")]
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.Empresas == null)
			{
				return NotFound();
			}

			var empresaModel = await _context.Empresas.FindAsync(id);
			if (empresaModel == null)
			{
				return NotFound();
			}
			return View(empresaModel);
		}

		// POST: Empresa/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[Authorize(Roles = "userPJ")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(string? id, [Bind("Id,Razao,Cnpj,Area")] EmpresaModel empresaModel)
		{
			if (id != empresaModel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(empresaModel);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!EmpresaModelExists(empresaModel.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(empresaModel);
		}

		// GET: Empresa/Delete/5
		[Authorize(Roles = "userPJ")]
		public async Task<IActionResult> Delete(string? id)
		{
			if (id == null || _context.Empresas == null)
			{
				return NotFound();
			}

			var empresaModel = await _context.Empresas
				.FirstOrDefaultAsync(m => m.Id == id);
			if (empresaModel == null)
			{
				return NotFound();
			}

			return View(empresaModel);
		}

		// POST: Empresa/Delete/5
		[Authorize(Roles = "userPJ")]
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int? id)
		{
			if (_context.Empresas == null)
			{
				return Problem("Entity set 'BancoContexto.Empresas'  is null.");
			}
			var empresaModel = await _context.Empresas.FindAsync(id);
			if (empresaModel != null)
			{
				_context.Empresas.Remove(empresaModel);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool EmpresaModelExists(string? id)
		{
			return (_context.Empresas?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
