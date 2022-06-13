using Microsoft.AspNetCore.Mvc;
using MVCResume.Data;

namespace MVCResume.Controllers
{
    public class ResumeController : Controller
    {
        private readonly MVCResumeContext _context;

        public ResumeController(MVCResumeContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ViewBag.ResumeSummary = "Motivated problem solver with a proven track record of integrity and dependency. " +
                "Driven to learn new skills as evidenced by completing a certificate program in computer programming " +
                "while working full time over the past year. Strong communication skills and experience working with " +
                "customers and colleagues. Equally as effective at working in a team as working in self-directed settings " +
                "to create high quality, innovative work. ";

            var job = _context.Job.ToList();
            ViewBag.JobCount = job.Count;

            // Create the date string
            List<string?> jobStartDate = _context.Job
                .Select(x => x.StartDate)
                .ToList();
            List<string?> jobEndDate = _context.Job
                .Select(x => x.EndDate)
                .ToList();
            ViewBag.JobStartAndEnd = new List<string>();
            for(int i = 0; i < job.Count; i++)
            {
                ViewBag.JobStartAndEnd.Add(String.Concat(jobStartDate[i], "-", jobEndDate[i]));
            }

            ViewBag.JobTitle = _context.Job
                .Select(x => x.Title)
                .ToList();

            // Create Company and Location string
            List<string?> jobCompanyName = _context.Job
                .Select(x => x.CompanyName)
                .ToList();
            List<string?> jobLocation = _context.Job
                .Select(x => x.CompanyLocation)
                .ToList();
            ViewBag.JobCompanyNameAndLocation = new List<string>();
            for(int i = 0; i < job.Count; i++)
            {
                if (jobCompanyName[i] == null)
                {
                    ViewBag.JobCompanyNameAndLocation.Add(String.Empty);
                }
                else if (jobCompanyName[i][jobCompanyName[i].Length - 1] == '.')
                {
                    ViewBag.JobCompanyNameAndLocation.Add(String.Concat(jobCompanyName[i], " ", jobLocation[i]));
                }
                else
                {
                    ViewBag.JobCompanyNameAndLocation.Add(String.Concat(jobCompanyName[i], " - ", jobLocation[i]));
                }
                
            }



            return View();
        }
    }
}
