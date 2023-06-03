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
        [Display(Name = "Id da empresa")]
        public string? Empresa { get; set; }


		[Column("vaga_cargo")]
		[Display(Name = "Cargo na empresa")]
		public string? Cargo { get; set; }


		[Column("vaga_salario")]
		[Display(Name = "Salario oferecido")]
		public decimal? Salario { get; set; }


		[Column("vaga_horas")]
		[Display(Name = "Carga Horaria")]
		public string? Horas { get; set; }


		[Column("vaga_area")]
		[Display(Name = "Área")]
		public string? Area { get; set; }


		[Column("vaga_inscricoes")]
		[Display(Name = "Inscricões")]
		public int? Inscricoes { get; set; }


		[Column("vaga_inicio")]
		[Display(Name = "Inicio")]
		public DateTime? Inicio { get; set; }


		[Column("vaga_fim")]
		[Display(Name = "Fim")]
		public DateTime? Fim { get; set; }

		[Column("vaga_local")]
		[Display(Name = "Local")]
		public string? Local { get; set; }

		
        [NotMapped]
        public string? nomeEmpresa { get; set; }
	}

}
