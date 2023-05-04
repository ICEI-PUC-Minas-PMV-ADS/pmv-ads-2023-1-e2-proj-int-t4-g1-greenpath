using GreenPath.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenPath.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        public DbSet<PessoaFisicaModel> PessoaFisica { get; set; }
        public DbSet<EmpresaModel> Empresas { get; set; }
    }
}
