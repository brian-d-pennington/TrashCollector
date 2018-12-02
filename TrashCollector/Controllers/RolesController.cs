using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class RolesController : Controller
    {
        public ApplicationDbContext db;

        public RolesController()
        {
            db = new ApplicationDbContext();
        }
        
        // GET: Roles
        public ActionResult Index()
        {
            var roles = db.Roles.ToList();
            return View(roles);
        }

        public ActionResult Create()
        {
            IdentityRole role = new IdentityRole();
            return View(role);
        }

        public ActionResult Create(IdentityRole role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}