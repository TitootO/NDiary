using System.ComponentModel.DataAnnotations.Schema;
using NDiary.Model;

namespace NDiary.Models
{
    public class Tutor
    {
        [ForeignKey("Teacher")]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        //public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Group> Groups { get; set; } = new List<Group>();
        //public IEnumerable<Group> Groups { get; set; }
        //public Tutor()
        //{
        //	Groups = new List<Group>();
        //}
    }
}
