using System.ComponentModel.DataAnnotations;

namespace iTechArt.Survey.BLL.DTO.ViewModels
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
    }
}
