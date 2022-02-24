using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                //this is entity framework and it is easier to map to our database using it instead of ADO.NET
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUps where c.Removed == null select c).ToList(); // this is another way called linking and then when this is ran it will only show the people who are subscribed

                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }
        // this is the method we will call to be able to remove the person from our db when the unsubscribed button is clicked and update our db and then we will redirect to our method above where we
        // use the linking to only show subscribed members to our admin page
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}