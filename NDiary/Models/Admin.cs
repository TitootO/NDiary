using NDiary.Model;

namespace NDiary.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}
