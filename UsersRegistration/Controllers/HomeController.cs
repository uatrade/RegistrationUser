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

        SelectList selectLists = new SelectList("Chose");
        
        public ActionResult Index()
        {
            ViewBag.ListUsers = users.userslist;
            ViewBag.FirstName = "";
            ViewBag.SelectList = selectLists;
            return View();
        }
        [HttpPost]
        
        public ActionResult Index(string firstNameSet, string lastNameSet, string emailSet, string passwordSet, string YourRole)
        {
            if (ModelState.IsValid)
            {
                users.AddUsers(new Users { firstName = firstNameSet, lastName = lastNameSet, email = emailSet, password = passwordSet, myrole = YourRole });
            }
            ViewBag.SelectList = selectLists;
            return View("Index");
        }
        public ActionResult AllUsersIndex()
        {
            ViewBag.ListUsers = users.userslist;
            return View("AllUsers");
        }

      
    }
}