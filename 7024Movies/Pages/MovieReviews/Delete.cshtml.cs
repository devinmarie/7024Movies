using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _7024Movies.Data;
using _7024Movies.Models;

namespace _7024Movies.Pages.MovieReviews
{
    public class DeleteModel : PageModel
    {
        private readonly _7024Movies.Data._7024MoviesContext _context;

        public DeleteModel(_7024Movies.Data._7024MoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MovieReview MovieReview { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReview = await _context.MovieReview.FirstOrDefaultAsync(m => m.MovieReviewId == id);

            if (MovieReview == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReview = await _context.MovieReview.FindAsync(id);

            if (MovieReview != null)
            {
                _context.MovieReview.Remove(MovieReview);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
