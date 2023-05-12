using System;
using System.ComponentModel.DataAnnotations;

namespace GreenPath.ViewModels
{
	public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string EmailAddress { get; set; }
        
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}