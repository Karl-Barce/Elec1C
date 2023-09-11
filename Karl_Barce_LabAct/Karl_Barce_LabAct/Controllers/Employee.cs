using Karl_Barce_LabAct.Models;
using Microsoft.AspNetCore.Mvc;

namespace Karl_Barce_LabAct.Controllers
{
    public class Employee : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
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
        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
    }
}
