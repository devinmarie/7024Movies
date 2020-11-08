using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _7024Movies.Data;
using _7024Movies.Models;

namespace _7024Movies.Pages.MovieReviewsThriller
{
    public class EditModel : PageModel
    {
        private readonly _7024Movies.Data._7024MoviesContext _context;

        public EditModel(_7024Movies.Data._7024MoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MovieReviewThriller MovieReviewThriller { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MovieReviewThriller = await _context.MovieReview.FirstOrDefaultAsync(m => m.MovieReviewThrillerId == id);

            if (MovieReviewThriller == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MovieReviewThriller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieReviewThrillerExists(MovieReviewThriller.MovieReviewThrillerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MovieReviewThrillerExists(int id)
        {
            return _context.MovieReview.Any(e => e.MovieReviewThrillerId == id);
        }
    }
}
