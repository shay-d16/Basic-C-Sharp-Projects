using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
                // This checks if any of the variables are an empty string or have a 'null' value.
            {
                return View("~/Views/Shared/Error.cshtml"); // '~' indicates the use of a relative path.
                //Here we used a relative path to the file 'Error.cshtml' to redirect to that view which is
                // an error page if any of the above conditions are true.
                // This 'Error.cshtml' file isn't located inside of a folder that matches a controller, it
                // is in the 'Shared' folder
            }
            else
            // This else statement will save the data submitted to our local database using ADO.NET
            {
                // The first thing you do with ADO.NET before you can access any information inside of a 
                // database is create a connection string (a string of characters within quotations that contains
                // specific information that allows access to the database like the server name or credential info, etc.)
                // The best way to get a connection string for ADO.NET is to connect to the database inside
                // of Visual Studio.
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;
                                            Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";
                return View("Success");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}