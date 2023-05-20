using System;
using GreenPath.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net;

namespace GreenPath.Data
{
    public class BancoContexto : IdentityDbContext<AppUser>
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        public DbSet<CertificacaoModel> certificacao { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<VagasModel> Vagas { get; set; }
        public DbSet<PessoaFisicaModel> PessoaFisica { get; set; }

    }
}