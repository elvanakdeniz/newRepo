using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
            :base("Server=.;Database=SchoolDB;Trusted_Connection=True")
        {
            Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }

    class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            UserRole userRole = new UserRole();
            userRole.RoleName = "Admin";
            context.UserRoles.Add(userRole);

            userRole = new UserRole();
            userRole.RoleName = "Standart";
            context.UserRoles.Add(userRole);
            context.SaveChanges();

            User admin = new User();
            admin.Firstname = "Elvan";
            admin.Lastname = "Akdeniz";
            admin.EMail = "ea@mail.com";
            admin.Password = "12345";
            admin.IsActive = true;
            admin.UserRoleID = context.UserRoles.FirstOrDefault(a => a.RoleName == "Admin").UserRoleID;
            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
