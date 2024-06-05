namespace NDiary.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
        public Role()
        {
            Users = new List<User>();
        }
    }
}
