using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsersRegistration.Models
{
    public class Users
    {
        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string myrole { get; set; }

        public List<Users> userslist = new List<Users>();

        public void AddUsers(Users usernew)
        {
            usernew.id = userslist.Count+1;
            userslist.Add(usernew);
        }
        
    }
}