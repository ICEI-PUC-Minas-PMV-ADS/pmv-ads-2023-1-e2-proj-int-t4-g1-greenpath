using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenPath.Data;
using GreenPath.Models;
using Microsoft.AspNetCore.Authorization;

namespace GreenPath.Controllers
{
    public class CertificacaoController : Controller
    {
        private readonly BancoContexto _context;

        public CertificacaoController(BancoContexto context)
        {
            _context = context;
        }

        // GET: Certificacao
        public async Task<IActionResult> Index(string BuscaString)
        {
            ViewData["Filtro"] = BuscaString;

            var certificacoes = from cert in _context.Certificacoes select cert;
            if (!String.IsNullOrEmpty(BuscaString))
            {
                certificacoes = certificacoes.Where(cert => cert.titulo.Contains(BuscaString));
            }

            // var certificacoes = await _context.certificacao.ToListAsync();
            return await Task.FromResult(View(certificacoes));
        }

        // GET: Certificacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Certificacoes == null)
            {
                return NotFound();
            }

            var certificacaoModel = await _context.Certificacoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (certificacaoModel == null)
            {
                return NotFound();
            }

            return View(certificacaoModel);
        }

        // GET: Certificacao/Create
        [Authorize(Roles = "userPJ")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certificacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "userPJ")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,titulo,desc")] CertificacaoModel certificacaoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(certificacaoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(certificacaoModel);
        }

        // GET: Certificacao/Edit/5
        [Authorize(Roles = "userPJ")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Certificacoes == null)
            {
                return NotFound();
            }

            var certificacaoModel = await _context.Certificacoes.FindAsync(id);
            if (certificacaoModel == null)
            {
                return NotFound();
            }
            return View(certificacaoModel);
        }

        // POST: Certificacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "userPJ")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("id,nome,titulo,desc")] CertificacaoModel certificacaoModel)
        {
            if (id != certificacaoModel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certificacaoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificacaoModelExists(certificacaoModel.id))
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
            return View(certificacaoModel);
        }

        // GET: Certificacao/Delete/5
        [Authorize(Roles = "userPJ")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Certificacoes == null)
            {
                return NotFound();
            }

            var certificacaoModel = await _context.Certificacoes
                .FirstOrDefaultAsync(m => m.id == id);
            if (certificacaoModel == null)
            {
                return NotFound();
            }

            return View(certificacaoModel);
        }

        // POST: Certificacao/Delete/5
        [Authorize(Roles = "userPJ")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Certificacoes == null)
            {
                return Problem("Entity set 'BancoContexto.certificacao'  is null.");
            }
            var certificacaoModel = await _context.Certificacoes.FindAsync(id);
            if (certificacaoModel != null)
            {
                _context.Certificacoes.Remove(certificacaoModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertificacaoModelExists(int? id)
        {
            return (_context.Certificacoes?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
