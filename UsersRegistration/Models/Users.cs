using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersRegistration.Models
{
    public class Users
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public Roles myrole;


        public List<Users> userslist = new List<Users>();

        public void AddUsers(Users usernew)
        {
            usernew.id = userslist.Count + 1;
            userslist.Add(usernew);
        }
        
    }
}