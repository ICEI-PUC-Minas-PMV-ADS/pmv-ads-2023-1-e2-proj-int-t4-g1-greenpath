using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenPath.Models;
using GreenPath.Data;
using Microsoft.Data.SqlClient;

namespace App_Web_GreenPath_BKED.Controllers
{
    public class VagasController : Controller
    {
        private readonly BancoContexto _context;

        public VagasController(BancoContexto context)
        {
            _context = context;
        }

         private string getEmpNome(string EmpId)
        {
            string EmpRazao; 

            using (SqlConnection con = new SqlConnection("Server=greenpath.database.windows.net;Initial Catalog=greenpath;Integrated Security=False;User Id=caminhoverde;Password=c6jmeNsmQyzgtLG"))
            {
                string query = "SELECT Pessoa_Juri.pessoa_juri_razao FROM Pessoa_Juri JOIN Vaga ON Vaga.vaga_empresa_id = @EmpId";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@EmpId", EmpId);
                    con.Open();
                    EmpRazao = (string)cmd.ExecuteScalar(); 
                    con.Close();
                }
            }

            return EmpRazao;
        }

        // GET: Vagas
        public async Task<IActionResult> Index(string BuscaString)
        {
            ViewData["Filtro"] = BuscaString;

            var vagas = from vaga in _context.Vagas select vaga;
            if (!String.IsNullOrEmpty(BuscaString))
            {
                vagas = vagas.Where(vaga => (vaga.Cargo.Contains(BuscaString) || vaga.Area.Contains(BuscaString) || vaga.Local.Contains(BuscaString) || vaga.Empresa.Contains(BuscaString)));
            }

            foreach (var item in vagas)
            {
                item.nomeEmpresa = getEmpNome(item.Empresa);
            }
            
            return await Task.FromResult(View(vagas));
        }

        // GET: Vagas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagasModel = await _context.Vagas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagasModel == null)
            {
                return NotFound();
            }

            vagasModel.nomeEmpresa = getEmpNome(vagasModel.Empresa);

            return View(vagasModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(VagasModel vagasModel)
        {
           
            List<Inscricoes> duplicate = _context.Inscricoes.ToList();

            foreach (var item in duplicate)
            {
                // UMA DAS LINHAS DE CÓDIGO MAIS CRIMINOSAS JÁ ESCRITA PELO SER HUMANO
                if(item.PessoaId.Equals(Global.CurrentUser.Id) && item.VagaId.Equals(vagasModel.Id)){
                    return Problem("Você já está cadastrado nessa vaga!");
                }
            }

            Inscricoes inscricao = new Inscricoes{
                PessoaId = Global.CurrentUser.Id,
                VagaId = vagasModel.Id
            };

            _context.Inscricoes.Add(inscricao);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Vagas");
        }


        // GET: Vagas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vagas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Empresa,Cargo,Salario,Horas,Area,Inscricoes,Inicio,Fim")] VagasModel vagasModel)
        {
            vagasModel.Empresa = Global.CurrentUser.Id;

            if (ModelState.IsValid)
            {
                _context.Add(vagasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vagasModel);
        }

        // GET: Vagas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagasModel = await _context.Vagas.FindAsync(id);
            if (vagasModel == null)
            {
                return NotFound();
            }
            return View(vagasModel);
        }

        // POST: Vagas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Empresa,Cargo,Salario,Horas,Area,Inscricoes,Inicio,Fim")] VagasModel vagasModel)
        {
            if (id != vagasModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vagasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VagasModelExists(vagasModel.Id))
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
            return View(vagasModel);
        }

        // GET: Vagas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vagas == null)
            {
                return NotFound();
            }

            var vagasModel = await _context.Vagas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vagasModel == null)
            {
                return NotFound();
            }

            return View(vagasModel);
        }

        // POST: Vagas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vagas == null)
            {
                return Problem("Entity set 'Contexto.Vagas'  is null.");
            }
            var vagasModel = await _context.Vagas.FindAsync(id);
            if (vagasModel != null)
            {
                _context.Vagas.Remove(vagasModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VagasModelExists(int id)
        {
          return (_context.Vagas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
