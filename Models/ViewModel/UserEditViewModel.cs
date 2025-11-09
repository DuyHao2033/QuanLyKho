using System.ComponentModel.DataAnnotations;

namespace QUANLYKHO.Models.ViewModel
{
    public class UserEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới (nếu muốn đổi)")]
        public string NewPassword { get; set; }
    }
}
