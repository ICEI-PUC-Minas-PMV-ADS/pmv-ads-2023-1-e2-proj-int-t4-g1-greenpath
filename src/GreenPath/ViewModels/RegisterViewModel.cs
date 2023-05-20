using System;
using System.ComponentModel.DataAnnotations;

namespace GreenPath.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo de email é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo deve ser um email válido")]
        public string EmailAddress { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O campo de senha é obrigatória")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$",
         ErrorMessage = "A senha deve conter pelo menos uma letra maiúscula, uma minúscula, um número e um caractere especial.")]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "O campo de confirmar senha é obrigatório")]
        [Compare("Password", ErrorMessage = "As senhas são diferentes")]
        public string ConfirmPassword { get; set; }
    }
}


