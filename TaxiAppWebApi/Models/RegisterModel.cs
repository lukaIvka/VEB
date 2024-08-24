namespace TaxiAppWebApi.Models
{
    public class RegisterModel
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public userType Type { get; set; }
        public string Picture { get; set; }
        public RegisterModel(string userName, string email, string password, string name, string lastname, DateTime dateOfBirth, string address, userType type, string picture)
        {
            UserName = userName;
            Email = email;
            Password = password;
            Name = name;
            Lastname = lastname;
            DateOfBirth = dateOfBirth;
            Address = address;
            Type = type;
            Picture = picture;
        }
    }

}
