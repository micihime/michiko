using System;
using System.Web.Mvc;

using Haiku.BusinessLogic.Data;
using Haiku.BusinessLogic.DBAccess;
using Haiku.BusinessLogic;

namespace Haiku.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Haiku
        public ActionResult Index()
        {
            return View();
        }

        // GET: Haiku/Edit/
        public ActionResult NewHaiku()
        {
            try
            {
                HaikuPoem haiku = new HaikuPoem();
                haiku = HaikuGenerator.GenerateRandomHaiku();
                return View(haiku);
            }
            catch (Exception e)
            {
                return View("Index");
            }
        }

        // POST: Haiku/Edit/
        [HttpPost]
        public ActionResult NewHaiku(HaikuPoem haiku)
        {
            try
            {
                haiku.NumberOfEvaluations++;
                HaikuDBAccess.SaveNewHaiku(haiku);
                return View("ThankYou");
            }
            catch (Exception e)
            {
                return View("Index");
            }
        }

        public ActionResult About(HaikuPoem haiku)
        {
            return View();
        }

        public ActionResult Contact(HaikuPoem haiku)
        {
            return View();
        }
    }
}
