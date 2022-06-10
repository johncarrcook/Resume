using Microsoft.AspNetCore.Mvc;

namespace MVCResume.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ResumeSummary = "Motivated problem solver with a proven track record of integrity and dependency. " +
                "Driven to learn new skills as evidenced by completing a certificate program in computer programming " +
                "while working full time over the past year. Strong communication skills and experience working with " +
                "customers and colleagues. Equally as effective at working in a team as working in self-directed settings " +
                "to create high quality, innovative work. ";
            return View();
        }
    }
}
