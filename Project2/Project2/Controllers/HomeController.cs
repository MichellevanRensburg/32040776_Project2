using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project2.Data;
using Project2.Models;
using Project2.ViewModel;

namespace Project2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly Project2DbContext Context;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly ImageModel image;


        public HomeController(ILogger<HomeController> logger, Project2DbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            Context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var items = Context.Image.ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ImageViewModel vm)
        {
            string stringFilename = UploadFile(vm);
            var student = new ImageModel
            {
                imageName = vm.imageName,
                imageFile = stringFilename,
                geoloaction =vm.geoloaction,
                tag = vm.tag,
                capturedDate = vm.capturedDate,
                capturedBy = vm.capturedBy
            };
            Context.Image.Add(image);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }

        private string UploadFile(ImageViewModel vm)
        {
            string fileName = null;
            if (vm.imageFile != null)
            {
                string uploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "images");
                fileName = Guid.NewGuid().ToString() + "-" + vm.imageFile.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using(var fileStream =  new FileStream(filePath, FileMode.Create))
                {
                    vm.imageFile.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
