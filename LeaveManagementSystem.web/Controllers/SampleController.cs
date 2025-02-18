using LeaveManagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.web.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            var valueData = new SampleViewModel
            {
                samplename = "HI OKOK"
            };
            return View(valueData);
        }
    }
}
