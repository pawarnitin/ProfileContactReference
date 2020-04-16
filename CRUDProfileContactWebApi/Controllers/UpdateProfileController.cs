using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDProfileContactWebApi.Models;
using System.Net.Http;

namespace CRUDProfileContactWebApi.Controllers
{
    public class UpdateProfileController : Controller
    {
        // GET: UpdateProfile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UPdateModel uPdateModel)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:50865/api/values/");
            var updateProfile = hc.PostAsJsonAsync<UPdateModel>("UPdateProfile", uPdateModel);
            updateProfile.Wait();
            ViewBag.message = "Profile updated successfully..!!";
            return View();
        }
    }
}