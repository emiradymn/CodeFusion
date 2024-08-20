using System.ComponentModel.DataAnnotations;

namespace CodeFusion.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 5)]
        [DataType(DataType.Password)] // tipinin şifre şeklinde olmasını söyler asp-for gibi
        [Display(Name = "Şifre")]
        public string? Password { get; set; }
    }
}