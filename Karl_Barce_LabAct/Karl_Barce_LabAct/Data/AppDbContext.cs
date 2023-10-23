using Karl_Barce_LabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace Karl_Barce_LabAct.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 100,
                    FirstName = "Karl Manuel",
                    LastName = "Barce",
                    isTenured = true,
                    HiringDate = DateTime.Parse("2019-08-15"),
                    Rank = Rank.AssistantProfessor
                },
                new Instructor()
                {
                    Id = 200,
                    FirstName = "Manuel",
                    LastName = "Barce",
                    isTenured = true,
                    HiringDate = DateTime.Parse("2002-10-28"),
                    Rank = Rank.AssociateProfessor
                }
                );
            modelBuilder.Entity<Student>().HasData(

                new Student()
                {
                    Id = 5,
                    Firstname = "Karl",
                    Lastname = "Barce",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-08-26"),
                    GPA = 1.5,
                    Email = "karl022@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    Firstname = "Test",
                    Lastname = "testing",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "testing@gmail.com"
                }
                );
            ;

        }

    }
}
