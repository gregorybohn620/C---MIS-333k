using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bohn_Van_HW4.Models;
using Microsoft.EntityFrameworkCore;

namespace Bohn_Van_HW4.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //You need one db set for each model class. For example:
        public DbSet<Movie> Movies { get; set; }
    }
}
