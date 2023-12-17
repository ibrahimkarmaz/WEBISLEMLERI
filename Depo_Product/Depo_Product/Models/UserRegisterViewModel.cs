using System.ComponentModel.DataAnnotations;

namespace Depo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen İsminizi Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı Giriniz.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen MailGiriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre Giriniz.")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar Giriniz.")]
        [Compare("password",ErrorMessage ="Lütfen şifrelerin eşleştiğinden emin olun.")]
        public string ConfirmPassword { get; set; }
    }
}
