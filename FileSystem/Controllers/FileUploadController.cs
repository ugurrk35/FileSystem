using Microsoft.AspNetCore.Mvc;

namespace FileSystem.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
