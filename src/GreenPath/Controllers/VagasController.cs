﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreenPath.Models;
using GreenPath.Data;

namespace App_Web_GreenPath_BKED.Controllers
{
    public class VagasController : Controller
    {
        private readonly BancoContexto _context;

        public VagasController(BancoContexto context)
        {
            _context = context;
        }

        // GET: Vagas
        public async Task<IActionResult> Index(string BuscaString)
        {
            ViewData["Filtro"] = BuscaString;

            var empresas = from emp in _context.Vagas select emp;
            if (!String.IsNullOrEmpty(BuscaString))
            {
                empresas = empresas.Where(emp => ( emp.Area.Contains(BuscaString)));
            }

            return await Task.FromResult(View(empresas));
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

            return View(vagasModel);
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