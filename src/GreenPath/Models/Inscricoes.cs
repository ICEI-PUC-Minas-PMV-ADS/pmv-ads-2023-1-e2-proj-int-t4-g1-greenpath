using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenPath.Models
{
    [Table("Inscricoes_Vagas")]
    public class Inscricoes
    {
        [Column("pessoa_fisica_id")]
        [Key]
        public string? PessoaId { get; set; }

        [Column("vaga_id")]
        public int? VagaId { get; set; }
	}
}