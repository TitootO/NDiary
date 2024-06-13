using System.ComponentModel.DataAnnotations.Schema;

namespace NDiary.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        [ForeignKey(nameof(Role))]
        public int? RoleId { get; set; }
    }
}
