using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TemplateTask.DataAccess;
using TemplateTask.Models;
using TemplateTask.ViewModels;

namespace TemplateTask.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;

        public ServiceController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<ServiceFeatures> service = _context.Service.ToList();
            return View(service);
        }
    }
}
