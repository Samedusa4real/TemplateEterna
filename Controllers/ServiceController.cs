using Microsoft.AspNetCore.Mvc;
using TemplateTask.DataAccess;
using TemplateTask.ViewModels;

namespace TemplateTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ServiceViewModel svm = new ServiceViewModel
            {
                ServiceFeatures = Data.ServiceFeatures
            };
            return View(svm);
        }

        public IActionResult Details()
        {
            ServiceViewModel svm = new ServiceViewModel
            {
                ServiceFeatures = Data.ServiceFeatures
            };
            return View(svm);
        }
    }
}
