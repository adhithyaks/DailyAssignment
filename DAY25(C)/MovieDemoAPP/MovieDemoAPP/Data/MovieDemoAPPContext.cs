using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieDemoAPP.model;

namespace MovieDemoAPP.Data
{
    public class MovieDemoAPPContext : DbContext
    {
        public MovieDemoAPPContext (DbContextOptions<MovieDemoAPPContext> options)
            : base(options)
        {
        }

        public DbSet<MovieDemoAPP.model.movie> movie { get; set; } = default!;
    }
}
