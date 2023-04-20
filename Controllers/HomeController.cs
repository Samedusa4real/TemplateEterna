using Microsoft.AspNetCore.Mvc;
using TemplateTask.DataAccess;
using TemplateTask.ViewModels;

namespace TemplateTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                HomeFeatures = Data.HomeFeatures
            };
            return View(hvm);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
