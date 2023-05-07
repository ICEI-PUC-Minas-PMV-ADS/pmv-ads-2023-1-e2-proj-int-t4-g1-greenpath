using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace GreenPath.Models
{
    [Table("Certificacao")]
    public class CertificacaoModel
    {
        [Column("cert_id")] // coluna no BD
        [Display(Name = "Id")] // muda o nome do input que o FOR estiver atribuido
        [Key]
        [AutoIncrement]
        public int? id { get; set; }

        [Column("cert_nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Preencha Nome !")]
        [MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
        public string? nome { get; set; }

        [Column("cert_titulo")]
        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "Preencha Titulo !")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres !")]
        public string? titulo { get; set; }

        [Column("cert_desc")]
        [Display(Name = "Descrição")]
        public string? desc { get; set; }

        //    public List<CertificacaoModel>? Certificados { get; set; }

        //    public List<CertificacaoModel> certificacaoModels(string busca)
        //    {

        //        var dbFactory = new OrmLiteConnectionFactory(
        //"Server=greenpath.database.windows.net;Initial Catalog=greenpath;Integrated Security=False;User Id=caminhoverde;Password=c6jmeNsmQyzgtLG",
        //SqlServerDialect.Provider);

        //        var db = dbFactory.Open();
        //        return db.Select<CertificacaoModel>(x => x.nome.Contains(busca));
        //    }
    }
}
