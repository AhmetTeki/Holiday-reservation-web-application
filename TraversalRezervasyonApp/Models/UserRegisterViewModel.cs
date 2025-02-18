using System.ComponentModel.DataAnnotations;

namespace TraversalRezervasyonApp.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Bu alan boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Username { get; set; }



        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
