using System.ComponentModel.DataAnnotations;

namespace ViewModels.CommerceTest
{
    public class Register
    {
        public int Id { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Şifreler uyuşmuyor. Lütfen tekrar deneyiniz.")]
        public string ConfirmPassword { get; set; }
    }
}
