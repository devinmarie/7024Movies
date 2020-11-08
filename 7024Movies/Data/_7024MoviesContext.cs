using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _7024Movies.Models;

namespace _7024Movies.Data
{
    public class _7024MoviesContext : DbContext
    {
        public _7024MoviesContext (DbContextOptions<_7024MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<_7024Movies.Models.MovieReviewThriller> MovieReview { get; set; }

        public DbSet<_7024Movies.Models.MovieReviewComedy> MovieReviewComedy { get; set; }

        public DbSet<_7024Movies.Models.MovieReviewOther> MovieReviewOther { get; set; }
    }
}
