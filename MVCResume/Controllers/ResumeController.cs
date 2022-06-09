using Microsoft.AspNetCore.Mvc;

namespace MVCResume.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
