using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDocumentation.Controllers
{
    public class WindTurbineController : Controller
    {
        // GET: WindTurbine
        /// <summary>
        /// The parent page which you see when you click on the project
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BatteryToInverter()
        {
            return View();
        }

        public ActionResult PowerGeneration()
        {
            return View();
        }

        public ActionResult Housing()
        {
            return View();
        }

        #region Electrical Components
        public ActionResult Generator()
        {
            return View();
        }

        public ActionResult PowerInverter()
        {
            return View();
        }

        public ActionResult FullBridgeRectifier()
        {
            return View();
        }

        public ActionResult SolarCharger()
        {
            return View();
        }

        public ActionResult CarBattery()
        {
            return View();
        }

        public ActionResult ElectricHeater()
        {
            return View();
        }
        #endregion
    }
}