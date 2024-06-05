using System.ComponentModel.DataAnnotations;
using NDiary.Model;

namespace NDiary.Models
{
    public class RegisterModel
    {
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        [Required(ErrorMessage = "Не указан Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }

        public Role Role { get; set; }
    }
}
