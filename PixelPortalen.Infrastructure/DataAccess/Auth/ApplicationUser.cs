using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PixelPortalen.Infrastructure.DataAccess.Auth
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public string Adress { get; set; }
        //public string City { get; set; }
        //public int Postalcode { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //[Phone]
        //public string PhoneNumber { get; set; }

    }

}
