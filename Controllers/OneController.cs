using Microsoft.AspNetCore.Mvc;
using OneFB.OneFBContext;
using OneFB.ViewModels;

namespace OneFB.Controllers
{
    public class OneController : Controller
    {
        private readonly AppDBContext _context;
        public OneController(AppDBContext context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            FBViewModel model = new FBViewModel()
            {
                Sliders = _context.Sliders.ToList(),
            };
            return View();
        }
    }
}
