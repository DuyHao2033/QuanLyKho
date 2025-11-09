using Microsoft.AspNetCore.Identity;

namespace QUANLYKHO.Models.ViewModel
{
    public class UserWithRolesViewModel
    {
        public IdentityUser User { get; set; }
        public List<string> Roles { get; set; }
    }
}
