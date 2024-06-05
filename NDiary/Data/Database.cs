using Microsoft.EntityFrameworkCore;
using NDiary.Model;
using NDiary.Models;

namespace NDiary.Data
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Day> Days { get; set; }

		public DbSet<Subject> Subjects { get; set; }
        public Database(DbContextOptions<Database> options)
            : base(options)
        {
            Database.EnsureDeleted();
           // Database.EnsureCreated();
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Role adminRole = new Role { Id = 1, Name = "Admin"};
        //    Role studentRole = new Role { Id = 2, Name = "Student"};
        //    Role parentRole = new Role { Id = 3, Name = "Parent" };
        //    Role teacherRole = new Role { Id = 4, Name = "Teacher" };

        //    User adminUser = new User { Id = 1, Login = "1", Password = "1", RoleId = adminRole.Id };
        //    User studentUser = new User { Id = 2, Login = "2", Password = "2", RoleId = studentRole.Id };
        //    User parentUser = new User { Id = 3, Login = "3", Password = "3", RoleId = parentRole.Id };
        //    User teacherUser = new User { Id = 4, Login = "4", Password = "4", RoleId = teacherRole.Id };

        //    modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, studentRole, parentRole, teacherRole });
        //    modelBuilder.Entity<User>().HasData(new User[] { adminUser, studentUser, parentUser, teacherUser });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
