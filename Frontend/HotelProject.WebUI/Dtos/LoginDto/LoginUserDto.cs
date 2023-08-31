using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez.")]
        public string Password { get; set; }
    }
}
