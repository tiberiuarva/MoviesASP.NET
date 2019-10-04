using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPRazorMovies.Models;

namespace ASPRazorMovies.Data
{
    public class ASPRazorMoviesContext : DbContext
    {
        public ASPRazorMoviesContext (DbContextOptions<ASPRazorMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<ASPRazorMovies.Models.Movie> Movie { get; set; }
    }
}
