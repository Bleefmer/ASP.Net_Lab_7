using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace FileDownloadApp.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {

            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";

            var fileStream = new MemoryStream(Encoding.UTF8.GetBytes(fileContent));

            return File(fileStream, "text/plain", $"{fileName}.txt");
        }
    }
}
