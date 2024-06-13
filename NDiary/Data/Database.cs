using Microsoft.EntityFrameworkCore;
using NDiary.Model;

namespace NDiary.Data
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Day> Days { get; set; }

		public DbSet<Subject> Subjects { get; set; }
        public Database(DbContextOptions<Database> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region
            Role adminRole = new Role {Id = 1, Name = "admin" };
            Role studentRole = new Role { Id = 2, Name = "student" };
            Role parentRole = new Role { Id = 3, Name = "parent" };
            Role teacherRole = new Role { Id = 4, Name = "teacher" };

            User adminUser = new User { Id = 1, Login = "1", Password = "1", RoleId = adminRole.Id};
            User studentUser = new User { Id = 2, Login = "2", Password = "2", RoleId = studentRole.Id };
            User parentUser = new User { Id = 3, Login = "3", Password = "3", RoleId = parentRole.Id };
            User teacherUser = new User { Id = 4, Login = "4", Password = "4", RoleId = teacherRole.Id };


            /// инициализация оценок для одного студента 
            Day day_1 = new Day(studentUser.Id) { Id = 1 };
            Day day_2 = new Day(studentUser.Id, 5) { Id = 2 };
            Day day_3 = new Day(studentUser.Id, 2) { Id = 3 };

            Teacher teacher = new Teacher() { Id = 1, Name = "Мария", Surname = "Иванова", Email = "он не должен быть обязательным", Phone="он тоже не обязательным должен быть", UserId = teacherUser.Id };

            Faculty facultInform = new Faculty() { Id = 1, Description = "описание хз чего, зачем оно в факультете?", Groups = new List<Group>().AsEnumerable(), Name = "Информационная безопасность" };
            
            Parent parentMom = new Parent() { Id = 1, Students = new List<Student>() , Name = "Natashaaaaa!!!!", Surname = "Ivanova", Phone = "свой не дам", Email= "убери что бы поле email было не обязательным или мого быть null", UserId = parentUser.Id }; 
            Student student_1 = new Student { Id = 1, Email = "Яусталпридумыватьэтухрень@mail.ru", Name="Ivan", Surname ="Ivanov", MomId = parentMom.Id, Phone = "8-800-555-35-35 проще позвонить чем у кого-то занимать", UserId = studentUser.Id };
            
            Group group201 = new Group() { Id = 1, Name = "201" , FacultyId = facultInform.Id, TutorId = teacher.Id };
            //student_1.GroupId = group201.Id;
            //student_1.Group = group201;

            //group201.Students = new List<Student> { student_1 };

            #endregion // инициализация стартовых ролей и пользователей

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, studentRole, parentRole, teacherRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser, studentUser, parentUser, teacherUser });
            modelBuilder.Entity<Day>().HasData(new Day[] { day_1, day_2, day_3});
            modelBuilder.Entity<Teacher>().HasData(new Teacher[] { teacher });
            modelBuilder.Entity<Faculty>().HasData(new Faculty[] { facultInform });
            modelBuilder.Entity<Student>().HasData(new Student[] { student_1 });
            modelBuilder.Entity<Group>().HasData(new Group[] { group201 });
            modelBuilder.Entity<Parent>().HasData(new Parent[] { parentMom });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
