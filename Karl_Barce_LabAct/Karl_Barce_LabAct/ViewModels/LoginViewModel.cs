using System.ComponentModel.DataAnnotations;

namespace Karl_Barce_LabAct.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "A user name is required")]
        public string? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A password is required")]
        public string? Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
