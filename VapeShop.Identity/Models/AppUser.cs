using Microsoft.AspNetCore.Identity;

namespace VapeShop.Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string Email {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
