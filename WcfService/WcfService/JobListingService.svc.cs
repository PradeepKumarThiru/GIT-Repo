using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobListingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JobListingService.svc or JobListingService.svc.cs at the Solution Explorer and start debugging.
    public class JobListingService : IJobListingService
    {
        public List<string> OpeningJobs()
        {
            List<string> lJobs = new List<string>();
            lJobs.Add("Dot Net Developer - 2, Experience 4 Years");
            lJobs.Add("Tester - 3, Experience 6 Years");
            lJobs.Add("Manager - 4, Experience 12 Years");
            lJobs.Add("Senior Developer - 2, Experience 7 Years");
            lJobs.Add("Senior Architect - 3, Experience 8 Years");
            lJobs.Add("Architect - 2, Experience 7 Years");
            lJobs.Add("Junior Developer - 2, Experience 4 Years");
            lJobs.Add("Front End Developer - 5, Experience 6 Years");
            lJobs.Add("Database Engineer - 1, Experience 9 Years");
            lJobs.Add("Senior Manager - 2, Experience 14 Years");
            lJobs.Add("Director - 1, Experience 18 Years");
            lJobs.Add("Support Engineer - 5, Experience 4 Years");
            lJobs.Add("Data Analyst - 10, Experience 7 Years");
            lJobs.Add("Business Analyst - 2, Experience 8 Years");
            return lJobs;
        }

        public List<string> OpeningJobsByRole(string roleStr)
        {
            List<string> lJobs = new List<string>();
            lJobs.Add("Dot Net Developer - 2, Experience 4 Years");
            lJobs.Add("Tester - 3, Experience 6 Years");
            lJobs.Add("Manager - 4, Experience 12 Years");
            lJobs.Add("Senior Developer - 2, Experience 7 Years");
            lJobs.Add("Senior Architect - 3, Experience 8 Years");
            lJobs.Add("Architect - 2, Experience 7 Years");
            lJobs.Add("Junior Developer - 2, Experience 4 Years");
            lJobs.Add("Front End Developer - 5, Experience 6 Years");
            lJobs.Add("Database Engineer - 1, Experience 9 Years");
            lJobs.Add("Senior Manager - 2, Experience 14 Years");
            lJobs.Add("Director - 1, Experience 18 Years");
            lJobs.Add("Support Engineer - 5, Experience 4 Years");
            lJobs.Add("Data Analyst - 10, Experience 7 Years");
            lJobs.Add("Business Analyst - 2, Experience 8 Years");

            var filter = from p in lJobs
                         where p.ToLower().Contains(roleStr.ToLower())
                         select p;
            List<string> fList = new List<string>();
            foreach(var item in filter)
            {
                fList.Add(item);
            }   

            return fList;
        }
    }
}
