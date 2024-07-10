using Microsoft.AspNetCore.Identity;

namespace AspNetCoreMvc_IdentityAuthenticationApp.Identity.Models
{
    public class AddUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
