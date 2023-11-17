using Microsoft.AspNetCore.Identity;

namespace Karl_Barce_LabAct.Data
{
    public class User: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
