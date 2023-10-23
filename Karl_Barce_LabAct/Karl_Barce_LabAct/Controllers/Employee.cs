using Karl_Barce_LabAct.Data;
using Karl_Barce_LabAct.Models;
using Karl_Barce_LabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace Karl_Barce_LabAct.Controllers
{
    public class Employee : Controller
    {
        private readonly AppDbContext _dbContext;

        public Employee(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Instructors);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditInstructor(int id)
        {

            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructor)
        {
            var st = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructor.Id);

            if (st != null)
            {
                st.Id = instructor.Id;
                st.FirstName = instructor.FirstName;
                st.LastName = instructor.LastName;
                st.isTenured = instructor.isTenured;
                st.Rank = instructor.Rank;
                st.HiringDate = instructor.HiringDate;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {


            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor instructor)
        {

            var st = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructor.Id);

            if (st != null)
            {
              
                _dbContext.Instructors.Remove(st);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
