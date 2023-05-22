using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVC.Controllers
{
    public class EmpController : Controller
    {
        public string Display()
        {

            return "hello vc code";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
