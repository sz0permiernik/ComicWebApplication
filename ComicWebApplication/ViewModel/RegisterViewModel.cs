using System.ComponentModel.DataAnnotations;

namespace ComicWebApplication.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Adres email jest wymagany.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [MinLength(8, ErrorMessage = "Hasło powinno posiadać minimum 8 znaków.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła nie pasują do siebie.")]
        public string ConfirmPassword { get; set; }
    }
}
