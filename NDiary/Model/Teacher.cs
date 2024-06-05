using System.ComponentModel.DataAnnotations.Schema;
using NDiary.Models;

namespace NDiary.Model
{
    public class Teacher
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public List<Subject> Subject { get; set; } = new List<Subject>();
    }
}
