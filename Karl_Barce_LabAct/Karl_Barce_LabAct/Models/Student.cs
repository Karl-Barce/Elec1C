using System.ComponentModel.DataAnnotations;

namespace Karl_Barce_LabAct.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "First name")]
        public string Firstname { get; set; }
        [Display(Name = "Last name")]
        public string Lastname { get; set; }
        [Display(Name = "GPA")]
        public double GPA { get; set; }
        [Display(Name = "Course")]
        public Course Course { get; set; }
        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string? Email { get; set; }


    }
}
