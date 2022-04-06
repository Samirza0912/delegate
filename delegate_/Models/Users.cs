using System;
namespace delegate_.Models
{
    public class Users : IEntity
    {
        /*User class (IEntity-ni implement edəcək)
- Username
- Email
- Role - Role enumı tipindən bir role property-i olacaq.
- ShowInfo()*/
        public int Id => throw new NotImplementedException();
        public string Username { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }

        public Users(string username, string email, int role)
        {
            Username = username;
            Email = email;
            Role = role;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}/n Name:{Username}/n Email:{Email}/n Role:{Role}");
        }
    }
}
