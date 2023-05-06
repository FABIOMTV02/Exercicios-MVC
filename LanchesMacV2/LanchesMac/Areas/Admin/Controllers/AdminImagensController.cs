using LanchesMac.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]


    public class AdminImagensController : Controller
    {
        private readonly ConfigurationImagens _myConfig;
        private readonly IWebHostEnvironment _hostingEnviroment;

        public AdminImagensController(IWebHostEnvironment hostEnvironment, 
            IOptions<ConfigurationImagens> myConfiguration)
        {
            _hostingEnviroment = hostEnvironment;
            _myConfig = myConfiguration.Value;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
