using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your name")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid email"), Required(ErrorMessage = "Enter email"), StringLength(450), Index(IsUnique = true)]
        public string Email { get; set; }

        [PasswordPropertyText, Required(ErrorMessage = "Enter password"), MinLength(8, ErrorMessage = "Password must consist of at least 8 symbols")]
        public string Password { get; set; }
    }
}
