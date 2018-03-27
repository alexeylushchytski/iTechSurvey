using System.ComponentModel.DataAnnotations;

namespace iTechArt.Survey.BLL.DTO.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter password again")]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match")]
        public string VerificationPassword { get; set; }


        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
    }
}