namespace NDiary.Model
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Group> Groups { get; set; } = new List<Group>();
    }
}
