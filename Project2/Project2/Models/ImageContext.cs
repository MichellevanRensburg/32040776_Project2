using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class ImageContext : DbContext
    {
        public ImageContext() { }

        public ImageContext(DbContextOptions<ImageContext> options): base(options)
        {

        }

        public DbSet<Image> Image { get; set; }
    }
}
