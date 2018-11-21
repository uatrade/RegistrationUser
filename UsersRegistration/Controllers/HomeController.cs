using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersRegistration.Models;

namespace UsersRegistration.Controllers
{
    public class HomeController : Controller
    {
        static Users users = new Users();
        static Roles roles = new Roles();
        SelectList selectLists = new SelectList("Chose");
        
        public ActionResult Index()
        {
            ViewBag.ListUsers = users.userslist;
            ViewBag.FirstName = "";
            ViewBag.SelectList = selectLists;
            return View();
        }
        [HttpGet]
        public ActionResult Index(string firstNameSet, string lastNameSet, string emailSet, string passwordSet, string Role)
        {
            users.AddUsers(new Users{firstName=firstNameSet, lastName=lastNameSet, email=emailSet, password=passwordSet });
            if(Role=="Admin")
            {
                users.AddUsers(new Users { firstName = firstNameSet, lastName = lastNameSet, email = emailSet, password = passwordSet });
            }
            ViewBag.ListUsers = users.userslist;
            ViewBag.SelectList = selectLists;
            return View("Index");
        }

      
    }
}