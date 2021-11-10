using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ImageModel
    {
        [Key]
        public int imageId { get; set; }
        public string imageFile { get; set; }
        public string imageName { get; set; }
        public string geoloaction { get; set; }
        public string tag { get; set; }
        public DateTime capturedDate { get; set; }
        public string capturedBy { get; set; }
    }
}
