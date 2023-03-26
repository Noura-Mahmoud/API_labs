using System.ComponentModel.DataAnnotations;

namespace InsDeptAPI.Models
{
    public class LoginUserDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
