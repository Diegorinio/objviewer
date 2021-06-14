using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelViewer.Models;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace ModelViewer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModelPreview(string objectname)
        {
            ViewData["object"] = objectname;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddModel(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return RedirectToAction("Index");

            var fileName = Path.GetFileName(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "assets", fileName);
            using( var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
