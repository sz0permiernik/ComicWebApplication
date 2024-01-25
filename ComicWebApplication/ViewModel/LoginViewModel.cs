using Microsoft.AspNetCore.Cors;
using Microsoft.Net.Http.Headers;
using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Adres email jest wymagany.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
