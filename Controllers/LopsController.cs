using EF_DBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_DBFirst.Controllers
{
    public class LopsController : Controller
    {
        // GET: Lops
        public ActionResult Index()
        {
            EF_DatabaseFirstEntities db = new EF_DatabaseFirstEntities();
            List<Lop> lops = db.Lop.ToList();
            return View(lops);
        }
    }
}