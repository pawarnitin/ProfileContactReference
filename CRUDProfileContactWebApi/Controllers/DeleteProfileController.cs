using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using CRUDProfileContactWebApi.Models;

namespace CRUDProfileContactWebApi.Controllers
{
    public class DeleteProfileController : Controller
    {
        // GET: DeleteProfile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DeleteModel deleteModel)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:50865/api/values/");
            var deleteProfile = hc.PostAsJsonAsync<DeleteModel>("DeleteProfile", deleteModel);
            deleteProfile.Wait();
            ViewBag.message = "Profile deleted successfully..!!";
            return View();
        }

    }
}