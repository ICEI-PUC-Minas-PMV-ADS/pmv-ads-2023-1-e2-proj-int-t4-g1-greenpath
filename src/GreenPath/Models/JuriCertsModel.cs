using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenPath.Models
{
    [Table("Pessoa_Juri_Certificacao")]
    public class JuriCertsModel
    {
        [Column("pessoa_juri_id")]
        [Key]
        public string? Emp_Id { get; set; }

        [Column("cert_id")]
        public int? Cert_Id { get; set; }
    }
}