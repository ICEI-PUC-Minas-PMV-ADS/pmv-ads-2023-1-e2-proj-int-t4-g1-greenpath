using System.ComponentModel.DataAnnotations.Schema;

namespace GreenPath.Models
{
    [Table("Pessoa_Fisica")]
    public class PessoaFisicaModel
    {
        [Column("pessoa_fisica_id")]
        public string? Id { get; set; }

        [Column("pessoa_fisica_nome")]
        public string? Nome { get; set; }

        [Column("pessoa_fisica_sobrenome")]
        public string? Sobrenome { get; set; }

        [Column("pessoa_fisica_cpf")]
        public string? Cpf { get; set; }

        [Column("pessoa_fisica_area")]
        public string? Area { get; set; }
    }
}