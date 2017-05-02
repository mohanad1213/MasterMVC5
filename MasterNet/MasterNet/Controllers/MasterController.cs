using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterNet.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
        var name="mohanad mohamed ali";
            name += " Job: software eng";
            return View();
        }
    }
}
