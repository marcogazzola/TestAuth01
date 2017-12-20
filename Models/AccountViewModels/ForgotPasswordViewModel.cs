using System.ComponentModel.DataAnnotations;

namespace TestAuth01.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}