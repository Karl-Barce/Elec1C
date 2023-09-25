using Karl_Barce_LabAct.Models;
using Karl_Barce_LabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace Karl_Barce_LabAct.Controllers
{
    public class Employee : Controller
    {
        private readonly IMyFakeDataService _fakeDataService;

        public Employee(IMyFakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }

        public IActionResult Index()
        {
            return View(_fakeDataService.InstructorList);
        }
        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _fakeDataService.InstructorList.FirstOrDefault(st => st.Id == id);

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
            _fakeDataService.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditInstructor(int id)
        {

            Instructor? instructor = _fakeDataService.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditInstructor(Instructor instructor)
        {
            var st = _fakeDataService.InstructorList.FirstOrDefault(st => st.Id == instructor.Id);

            if (st != null)
            {
                st.Id = instructor.Id;
                st.FirstName = instructor.FirstName;
                st.LastName = instructor.LastName;
                st.isTenured = instructor.isTenured;
                st.Rank = instructor.Rank;
                st.HiringDate = instructor.HiringDate;
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {


            Instructor? instructor = _fakeDataService.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor instructor)
        {

            var st = _fakeDataService.InstructorList.FirstOrDefault(st => st.Id == instructor.Id);

            if (st != null)
            {
              
                _fakeDataService.InstructorList.Remove(st);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
