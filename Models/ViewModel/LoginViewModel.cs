using System.ComponentModel.DataAnnotations;

namespace QUANLYKHO.Models.ViewModel
{
    // Ensure only one definition of LoginViewModel exists in this namespace.
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
