using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP05.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
      

        private readonly Dictionary<string , (string Password, List<string>Rloes)> user = new()
       {
           {"osama",("pas123",new List<string> { }) },
           {"zhran",("pas176823",new List<string> { "zhran", "Admin" }) },
       };

       

        public bool AuthenticateUser(string username, string password)
        {
          
            if (user.TryGetValue(username, out var userInfo))
            {
                return userInfo.Password == password;
            }
            return false;

        }

        public bool AuthorizeUser(string username,string role)
        {

           if (user.TryGetValue (username, out var userInfo))
            {
                return userInfo.Rloes.Contains (role);
            }
           return false;
            

        }
       


    }
}
