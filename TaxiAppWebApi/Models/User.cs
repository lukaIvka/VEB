using Microsoft.AspNetCore.Identity;
using System.Fabric.Management.ServiceModel;

namespace TaxiAppWebApi.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public userType Type { get; set; }
        public string Picture { get; set; }

        public User() : base()
        {
        }
    }
}
