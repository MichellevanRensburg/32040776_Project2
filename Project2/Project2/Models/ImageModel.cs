using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ImageModel
    {
        [Key]
        public int imageId { get; set; } 

        [Column(TypeName = "nvarchar(50)")]
        public string imageName { get; set; }

        [Column(TypeName = "nvarchar(50)")]

        [DisplayName("image File Name")]
        public string imageFileName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string geoloaction { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string tag { get; set; }

        [Column(TypeName = "date")]
        public DateTime capturedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string capturedBy { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
