using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstagiosDEIS.Controllers
{
    public class EstagiosController : Controller
    {
        // GET: Estagios
        public ActionResult Lista()
        {
            return View();
        }
    }
}