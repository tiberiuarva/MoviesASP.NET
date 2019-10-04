using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPRazorMovies.Data;
using ASPRazorMovies.Models;

namespace ASPRazorMovies.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly ASPRazorMovies.Data.ASPRazorMoviesContext _context;

        public CreateModel(ASPRazorMovies.Data.ASPRazorMoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}