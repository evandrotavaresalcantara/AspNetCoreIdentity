using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentity.Mvc.Habilitar.ViewModel
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato do e-mail inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }


        [Display(Name = "Lembrar-me")]
        public bool Lembrarme { get; set; }
    }
}
