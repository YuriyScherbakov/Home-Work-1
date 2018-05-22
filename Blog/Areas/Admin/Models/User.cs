using System.ComponentModel.DataAnnotations;

namespace Blog.Areas.admin.Models
    {
    public class User
        {
        [Required]
        [Display (Name = "Имя")]
        public string UserName
            {
            get; set;
            }
        [Required]
        [Display (Name = "Пароль")]
        [DataType (DataType.Password)]
        public string Password
            {
            get; set;
            }
        }
    }