﻿using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.IdentityDto.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim Alanı Gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyisim Alanı Gereklidir.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail Alanı Gereklidir.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir.")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
