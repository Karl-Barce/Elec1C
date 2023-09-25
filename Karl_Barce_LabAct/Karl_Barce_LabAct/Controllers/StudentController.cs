using Karl_Barce_LabAct.Models;
using Karl_Barce_LabAct.Services;
using Microsoft.AspNetCore.Mvc;

namespace Karl_Barce_LabAct.Controllers
{
    
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _fakeData;

        public StudentController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
        }
        public IActionResult Index()
        {

            return View(_fakeData.StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult Addstudent()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Addstudent(Student newStudent)
        {
            _fakeData.StudentList.Add(newStudent);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {

            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult EditStudent(Student studentStudent)
        {
           var st = _fakeData.StudentList.FirstOrDefault(st =>st.Id == studentStudent.Id);

            if (st != null)
            {
                st.Id = studentStudent.Id;
                st.Firstname = studentStudent.Firstname;
                st.Lastname = studentStudent.Lastname;
                st.GPA = studentStudent.GPA;
                st.Course = studentStudent.Course;
                st.AdmissionDate = studentStudent.AdmissionDate;
                st.Email = studentStudent.Email;
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {


            Student? student = _fakeData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult DeleteStudent(Student student)
        {

            var st = _fakeData.StudentList.FirstOrDefault(st => st.Id == student.Id);

            if (st != null)
            {

                _fakeData.StudentList.Remove(st);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
