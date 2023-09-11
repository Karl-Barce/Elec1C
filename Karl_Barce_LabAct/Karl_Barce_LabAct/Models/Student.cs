namespace Karl_Barce_LabAct.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }
    public class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double GPA { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Email { get; set; }
    }
}
