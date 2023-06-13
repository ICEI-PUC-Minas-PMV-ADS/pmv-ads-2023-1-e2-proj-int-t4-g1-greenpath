using System.ComponentModel.DataAnnotations;
using GreenPath.Models;

namespace GreenPath.ViewModels
{
    public class DataViewModel
    {
        // [Display(Name = "Candidato")]
        // [Required]
        // public bool Candidate { get; set; } //true == candidate; false = company

        //Dados de Pessoa
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [Display(Name = "Name")]
        public string? Name { get; set; }
        
        [Required(ErrorMessage = "O campo de Sobrenome é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O Sobrenome deve ter no mínimo 3 caracteres.")]
        [Display(Name = "Sobrenome")]
        public string? Surname { get; set; }

        [Display(Name = "Profissão")]
        public string? Profession { get; set; }

        [Display(Name = "Currículo")]
        public string? Curriculum { get; set; }

        //Dados de Empresa
        [Display(Name = "Razão Social")]
        public string? CompanyName { get; set; }
        
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo de CPF é obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O campo de CNPJ é obrigatório")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CNPJ deve ter 11 caracteres.")]
        [Display(Name = "CNPJ")]
        public string? CNPJ { get; set; }
        
        [Display(Name = "Area")]
        public string? Area { get; set; }

        [Display(Name = "Certificações")]
        public List<CertificacaoModel>? Certificates { get; set; }

        //Dados Compartilhados de empresa e candidatos que são OBRIGATÓRIOS
        
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo de é Email obrigatório")]
        [EmailAddress(ErrorMessage = "Por favor, insira um endereço de e-mail válido.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "O endereço de email deve ter entre 6 e 50 caracteres.")]
        public string? Email { get; set; }
        
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo de Telefone é obrigatório")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Insira o número 9 seguido dos 8 digitos do telefone, sem espaços.")]
        public string? Phone { get; set; }
        
        [Display(Name = "País")]
        [Required(ErrorMessage = "O campo de País é obrigatório")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome do país deve ter entre 4 e 50 caracteres.")]
        public string? Country { get; set; }
        
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo de Estado é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome do estado deve ter entre 3 e 50 caracteres.")]
        public string? State { get; set; }
        
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo de Cidade é obrigatório")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome da cidade deve ter entre 4 e 50 caracteres.")]
        public string? City { get; set; }

        [Display(Name = "Rua")]
        [Required(ErrorMessage = "O campo de Rua é obrigatório")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome da rua deve ter entre 4 e 50 caracteres.")]
        public string? Street { get; set; }

        [Url(ErrorMessage = "Insira a URL do seu.")]
        public string? Instagram { get; set; }

        [Url(ErrorMessage = "Insira a URL do seu.")]
        public string? Facebook { get; set; }

        [Url(ErrorMessage = "Insira a URL do seu.")]
        public string? Github { get; set; }

        [Url(ErrorMessage = "Insira a URL do seu.")]
        public string? Pinterest { get; set; }

        public static implicit operator DataViewModel(List<CertificacaoModel> v)
        {
            throw new NotImplementedException();
        }
    }
}


