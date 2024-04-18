using EF_DBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_DBFirst.Controllers
{
    public class KhoasController : Controller
    {
        // GET: Khoas
        public ActionResult Index()
        {
            EF_DatabaseFirstEntities db = new EF_DatabaseFirstEntities();
            List<Khoa> khoas = db.Khoa.ToList();
            return View(khoas);
        }
    }
}