using EF_DBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_DBFirst.Controllers
{
    public class SinhViensController : Controller
    {
        // GET: SinhViens
        public ActionResult Index()
        {
            EF_DatabaseFirstEntities db = new EF_DatabaseFirstEntities();
            List<SinhVien> sinhViens = db.SinhVien.Where(sv => sv.LopId == sv.Lop.Id && sv.Lop.KhoaId == sv.Lop.Khoa.Id
                                    && sv.Lop.Khoa.Name.Contains("Công nghệ số") && sv.Age >= 18 && sv.Age <= 20).ToList();
            return View(sinhViens);
        }
    }
}