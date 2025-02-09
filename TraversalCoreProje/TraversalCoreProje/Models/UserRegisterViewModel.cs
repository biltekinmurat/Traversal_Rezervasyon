﻿using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Adınızı Giriniz !")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz !")]
        public required string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public required string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresini Giriniz")]
        public required string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public required string ConfirmPassword { get; set; }




    }
}
