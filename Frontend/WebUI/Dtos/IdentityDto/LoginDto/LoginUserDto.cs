
using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.IdentityDto.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanıcı Gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir.")]
        public string Password { get; set; }
    }
}
