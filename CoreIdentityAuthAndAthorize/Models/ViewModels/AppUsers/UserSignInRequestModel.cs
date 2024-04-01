using System.ComponentModel.DataAnnotations;

namespace CoreIdentityAuthAndAthorize.Models.ViewModels.AppUsers
{
    public class UserSignInRequestModel
    {
        [Required(ErrorMessage ="Kullanıcı ismi girilmesi zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Sifre alanız zorunludur")]
        [MinLength(3,ErrorMessage ="Minimum 3 karakter girmelisiniz")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string? ReturnUrl { get; set; }

    }
}
