using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDiary.Model
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Student> Students { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public virtual int? UserId { get; set; }
        public Parent()
        {
            Students = new List<Student>();
        }
    }
}
