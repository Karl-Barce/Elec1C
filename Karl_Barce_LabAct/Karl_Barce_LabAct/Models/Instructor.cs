using System.ComponentModel.DataAnnotations;

namespace Karl_Barce_LabAct.Models
{
    public enum Rank
    {
        instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "is Tenured")]
        public bool isTenured { get; set; }
        [Required]
        [Display(Name = "Academic rank")]
        public Rank Rank { get; set; }
        [Display(Name = "Hiring date")]
        public DateTime HiringDate { get; set; }

        /*[RegularExpression("[0-9]{3}-[0-9]{3}-[0-9]{4}", ErrorMessage = "you must follow the format 000-000-0000!")]
        [Display(Name = "Office phone number")]
        public String? Phonenumber { get; set; }

        [EmailAddress]
        [Display(Name = "Email address")]
        public String? Email { get; set; }

        [Url]
        [Display(Name = "Personal webpage")]
        public String? EmailAddress { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Password (we won't use this!)")]
        [DataType(DataType.Password)]
        public String? UnusedPassword { get; set; }*/

    }
}
