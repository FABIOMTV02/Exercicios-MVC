using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {

        //Biblioteca do Requiredd diferente do professor possivel erro, aula 75
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuario")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        public string ReturnUrl{ get; set; }
    }
}
