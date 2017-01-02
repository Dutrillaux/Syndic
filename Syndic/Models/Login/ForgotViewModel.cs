using System.ComponentModel.DataAnnotations;

namespace Syndic.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}