using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _7024Movies.Data;
using _7024Movies.Models;

namespace _7024Movies.Pages.MovieReviewsComedy
{
    public class IndexModel : PageModel
    {
        private readonly _7024Movies.Data._7024MoviesContext _context;

        public IndexModel(_7024Movies.Data._7024MoviesContext context)
        {
            _context = context;
        }

        public IList<MovieReviewComedy> MovieReviewComedy { get;set; }

        public async Task OnGetAsync()
        {
            MovieReviewComedy = await _context.MovieReviewComedy.ToListAsync();
        }
    }
}
