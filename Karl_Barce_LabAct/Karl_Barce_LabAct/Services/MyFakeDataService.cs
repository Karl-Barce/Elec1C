using Karl_Barce_LabAct.Models;
using System.Security.Cryptography.X509Certificates;

namespace Karl_Barce_LabAct.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,Firstname = "Gabriel",Lastname = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,Firstname = "Zyx",Lastname = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,Firstname = "Aerdriel",Lastname = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };

            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Jason",LastName = "Beltran", Rank = Rank.instructor, HiringDate = DateTime.Parse("2022-08-26"), isTenured = true
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Mikhail",LastName = "De Guzman", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07"), isTenured = false
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Manuel",LastName = "Barce", Rank = Rank.Professor, HiringDate = DateTime.Parse("2020-01-25"), isTenured = true
                }
            };
        }

        
    }
}
