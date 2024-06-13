using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDiary.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public Group? Group { get; set; }
        [ForeignKey(nameof(Group))]
        public int? GroupId { get; set; }
        public int? MomId { get; set; }
        public int? DadId { get;set; }
    }
}
