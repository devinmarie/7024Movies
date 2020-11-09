﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _7024Movies.Data;
using _7024Movies.Models;

namespace _7024Movies.Pages.MovieReviewsThriller
{
    public class CreateModel : PageModel
    {
        private readonly _7024Movies.Data._7024MoviesContext _context;

        public CreateModel(_7024Movies.Data._7024MoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MovieReviewThriller MovieReviewThriller { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MovieReview.Add(MovieReviewThriller);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
