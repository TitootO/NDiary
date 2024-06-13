using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NDiary.Models;

namespace NDiary.Model
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public virtual int? UserId { get; set; }
        public List<Subject> Subject { get; set; }

        public Teacher() 
        {
        Subject = new List<Subject>();
        }
    }
}
