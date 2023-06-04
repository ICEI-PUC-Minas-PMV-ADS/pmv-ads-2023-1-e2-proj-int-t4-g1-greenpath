using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ServiceStack.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace GreenPath.Models
{
	[Table("Pessoa_Juri")]
	public class EmpresaModel
	{
		[Column("pessoa_juri_id")] // coluna no BD
		[Display(Name = "Id")] // muda o nome do input que o FOR estiver atribuido
		[Key]
		[AutoIncrement]
		public string? Id { get; set; }

		[Column("pessoa_juri_razao")]
		[Display(Name = "Razão Social")]
		[Required(ErrorMessage = "Preencha Razão!")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public string? Razao { get; set; }

		[Column("pessoa_juri_cnpj")]
		[Display(Name = "CNPJ")]
		[Required(ErrorMessage = "Preencha CNPJ !")]
		[MinLength(3, ErrorMessage = "Mínimo de 13 caracteres !")]
		public string? Cnpj { get; set; }

		[Column("pessoa_juri_area")]
		[Display(Name = "Área")]
		[Required(ErrorMessage = "Preencha Área !")]
		[MinLength(3, ErrorMessage = "Mínimo de 2 caracteres !")]
		public string? Area { get; set; }

		
        [Column("pessoa_juri_pais")]
        public string? Pais { get; set; }

        [Column("pessoa_juri_estado")]
        public string? Estado { get; set; }

        [Column("pessoa_juri_cidade")]
        public string? Cidade { get; set; }

        [Column("pessoa_juri_email")]
        public string? Email { get; set; }

        [Column("pessoa_juri_telefone")]
        public string? Telefone { get; set; }
	}
}
