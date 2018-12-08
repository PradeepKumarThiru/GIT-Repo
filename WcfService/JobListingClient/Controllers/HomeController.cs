using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobListingClient.JobListingSvc;

namespace JobListingClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JobListing()
        {
            List<string> jobList = new List<string>();

            JobListingServiceClient jbSvc = new JobListingServiceClient();
            foreach(var item in jbSvc.OpeningJobs())
            {
                jobList.Add(item);
            }

            return View(jobList);
        }

        [HttpPost]
        public ActionResult JobListing(FormCollection collection)
        {
            List<string> jobList = new List<string>();
            string role = "";
            role = collection["txtRole"].ToString();

            JobListingServiceClient jbSvc = new JobListingServiceClient();
            foreach (var item in jbSvc.OpeningJobsByRole(role))
            {
                jobList.Add(item);
            }

            return View(jobList);
        }
    }
}