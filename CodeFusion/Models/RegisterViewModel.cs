using System.ComponentModel.DataAnnotations;

namespace CodeFusion.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string? UserName { get; set; }

        [Required]
        [Display(Name = "Ad Soyad")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 5)]
        [DataType(DataType.Password)] // tipinin şifre şeklinde olmasını söyler asp-for gibi
        [Display(Name = "Şifre")]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Parolanız eşleşmiyor")] // yukardaki password ile karşılartırıyor
        [Display(Name = "Şifre tekrar")]
        public string? ConfirmPassword { get; set; }

    }
}