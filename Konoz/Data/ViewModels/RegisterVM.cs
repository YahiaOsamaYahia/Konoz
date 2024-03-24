using System.ComponentModel.DataAnnotations;

namespace Konoz.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email Adress")]
        [Required(ErrorMessage = "Email Adress is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "The password must be at least 8 characters long and include one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
