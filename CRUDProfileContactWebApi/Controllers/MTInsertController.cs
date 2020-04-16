using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDProfileContactWebApi.Models;
using System.Net.Http;

namespace CRUDProfileContactWebApi.Controllers
{
    public class MTInsertController : Controller
    {
        // GET: MTInsert
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(InsertModel insertModel)
        {
            HttpClient hc=new HttpClient();
            hc.BaseAddress=new Uri("http://localhost:50865/api/values/");
            var insertProfile = hc.PostAsJsonAsync<InsertModel>("CreateProfile", insertModel);
            insertProfile.Wait();
            ViewBag.message = "Profile created successfully..!!";
            return View();
        }
    }
}