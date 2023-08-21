using PersonnelInformationDL.Context;
using PersonnelInformationEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonnelInformationUI.Controllers
{
    public class PersonnelController : Controller
    {
        // GET: Personnel
        MyContext myc = new MyContext();
        public ActionResult Index()
        {
            var personnel = myc.PersonnelTable.ToList();
            return View(personnel);
        }
        [HttpGet]
        public ActionResult AddPersonnel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPersonnel(Personnel p)
        {
            myc.PersonnelTable.Add(p);
            myc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeletePersonnel(int id)
        {
            var per = myc.PersonnelTable.Find(id);
            if (per == null)
                return HttpNotFound();
            myc.PersonnelTable.Remove(per);
            myc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FillPersonnel(int id)
        {
            var per = myc.PersonnelTable.Find(id);
            return View("FillPersonnel", per);
        }
        public ActionResult UpdatePersonnel(Personnel p)
        {
            var prs = myc.PersonnelTable.Find(p.ID);
            prs.Name = p.Name;
            prs.Surname = p.Surname;
            prs.Email = p.Email;
            prs.TcNo = p.TcNo;
            prs.Gender = p.Gender;
            prs.BirthDate = p.BirthDate;
            prs.Education = p.Education;
            prs.Job = p.Job;
            myc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}