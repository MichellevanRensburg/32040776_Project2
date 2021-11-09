using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Project2.Models
{
    public class Image
    {
        [Key]
        public int imageID { get; set; }
        [Required(ErrorMessage = "Please enter image name")]
        public string imageName { get; set; }

        [Required(ErrorMessage = "Please upload a image")]
        public string image { get; set; }

        public string geolocation { get; set; }

        [Required(ErrorMessage = "Please enter tag to catergorise the image")]
        public string tag { get; set; }
        public string capDate { get; set; }
        public string capBy { get; set; }
    }
}
