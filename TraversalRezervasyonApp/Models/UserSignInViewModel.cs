using System.ComponentModel.DataAnnotations;

namespace TraversalRezervasyonApp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını boş geçmeyin!!!")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen  şifre kısmını boş geçmeyin!!!")]
        public string password { get; set; }
    }
}
