using System;
using System.ComponentModel.DataAnnotations;

namespace GreenPath.ViewModels
{
	public class RegisterViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo de email é obrigatório")]
        public string EmailAddress { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo de senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Required(ErrorMessage = "O campo de confirmar Senha é obrigatório")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmPassword { get; set; }
    }
}


