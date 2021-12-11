using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();

                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                // A common practice on the controller is to map your database object to a view model. So let's create an empty
                //  list with the 'SignupVm' data type: 
                var signupVms = new List<SignupVm>();
                // The data type is obvious here so it's best practice to use the 'var' keyword in this instance.

                // Then we will loop through all the 'signups':
                foreach (var signup in signups)
                {
                    // Here, we will map properties between objects
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}