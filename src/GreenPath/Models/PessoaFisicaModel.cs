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

        [Column("pessoa_fisica_pais")]
        public string? Pais { get; set; }

        [Column("pessoa_fisica_estado")]
        public string? Estado { get; set; }

        [Column("pessoa_fisica_cidade")]
        public string? Cidade { get; set; }

        [Column("pessoa_fisica_email")]
        public string? Email { get; set; }

        [Column("pessoa_fisica_telefone")]
        public string? Telefone { get; set; }

        [Column("pessoa_fisica_github")]
        public string? Github { get; set; }

        [Column("pessoa_fisica_instagram")]
        public string? Instagram { get; set; }

        [Column("pessoa_fisica_facebook")]
        public string? Facebook { get; set; }

        [Column("pessoa_fisica_pinterest")]
        public string? Pinterest { get; set; }
    }
}