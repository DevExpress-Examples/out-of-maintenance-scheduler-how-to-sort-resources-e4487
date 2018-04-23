using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.XtraScheduler;

namespace DevExpressMvcApplication1.Views {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(SchedulerDataHelper.DataObject);
        }

        public ActionResult SchedulerPartial() {
            ViewBag.ResourcesSortType = (Request.Params["ResourcesSortType"] != null) ? int.Parse(Request.Params["ResourcesSortType"]) : (int)ResourcesSortOrder.None;
            return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject);
        }
    }
}
