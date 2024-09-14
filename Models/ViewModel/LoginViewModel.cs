using System.ComponentModel.DataAnnotations;

namespace identity_task.Models.ViewModel
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        [MaxLength(40)]
        [Display (Name ="Email Address")]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(40)]
      
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
