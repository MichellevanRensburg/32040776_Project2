using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class ImageController : Controller
    {
        private readonly ImageContext _context;

        public ImageController(ImageContext context)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile image)
        {
            if (image != null)
            {
                if(image.Length > 0)
                {
                    var imageName = Path.GetFileName(image.FileName);
                    var imageExtetion = Path.GetExtension(imageName);
                }
            }
        }
    }
}
