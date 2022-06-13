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
            ViewBag.JobCount = job.Count();
            ViewBag.JobStartDate = _context.Job
                .Select(x => x.StartDate).ToList();
            ViewBag.JobEndDate = _context.Job
                .Select(x => x.EndDate).ToList();


            return View();
        }
    }
}
