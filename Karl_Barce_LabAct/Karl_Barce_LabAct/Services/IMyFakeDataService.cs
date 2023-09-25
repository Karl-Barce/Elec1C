using Karl_Barce_LabAct.Models;

namespace Karl_Barce_LabAct.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
