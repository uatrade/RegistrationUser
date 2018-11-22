using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersRegistration.Models
{
    public class Roles
    {
        public string Name { get; set; }

        public Roles(string Name)
        {
            this.Name = Name;
        }

    }
}