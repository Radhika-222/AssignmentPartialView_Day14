using Assignment_Day14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_Day14.Controllers
{
    public class TeamController : Controller
    {

        // GET: Team
        public ActionResult Index()
        {
            List<Team> ListTeams = new List<Team>()
        {
            new Team(){TeamId=1,TeamName="India",NOVVC=3},
            new Team(){TeamId=2,TeamName="Australia",NOVVC=4},
            new Team(){TeamId=3,TeamName="West Indies",NOVVC=2},
            new Team(){TeamId=4,TeamName="England",NOVVC=1}
        };
            return View(ListTeams);
        }
        public ActionResult PAction()
        {
            return PartialView("PView");
        }
        public ActionResult Display()
        {
            ViewBag.msg = "We can display Team details from here";
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.msg = "We can register Team from here";
            return View();
        }

    }
}