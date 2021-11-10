using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.ViewModel
{
    public class ImageViewModel
    {
        public IFormFile imageFile { get; set; }
        public string imageName { get; set; }
        public string geoloaction { get; set; }
        public string tag { get; set; }
        public DateTime capturedDate { get; set; }
        public string capturedBy { get; set; }
    }
}
