using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    public class AdminGraficosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
