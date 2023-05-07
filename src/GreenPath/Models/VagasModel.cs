using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenPath.Models
{
    [Table("Vaga")]
    public class VagasModel
    {
        [Column("vaga_id")]
        [Display(Name = " Id")]
        public int Id { get; set; }

        [Column("vaga_empresa_id")]
        [Display(Name = "Nome da empresa")]
        public int	Empresa { get; set; }


		[Column("vaga_cargo")]
		[Display(Name = "Cargo na empresa")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public string? Cargo { get; set; }


		[Column("vaga_salario")]
		[Display(Name = "Salario oferecido")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public double? Salario { get; set; }


		[Column("vaga_horas")]
		[Display(Name = "Carga Horaria")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public string? Horas { get; set; }


		[Column("vaga_area")]
		[Display(Name = "Área")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public string? Area { get; set; }


		[Column("vaga_inscricoes")]
		[Display(Name = "Inscricões")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public int? Inscricoes { get; set; }


		[Column("vaga_inicio")]
		[Display(Name = "Inicio")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public DateTime? Inicio { get; set; }


		[Column("vaga_fim")]
		[Display(Name = "Razão Social")]
		[MinLength(5, ErrorMessage = "Mínimo de 5 caracteres !")]
		public DateTime? Fim { get; set; }

	}

}
