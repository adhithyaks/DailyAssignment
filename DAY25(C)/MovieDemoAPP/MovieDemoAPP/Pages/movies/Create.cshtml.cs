using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieDemoAPP.Data;
using MovieDemoAPP.model;

namespace MovieDemoAPP.Pages.movies
{
    public class CreateModel : PageModel
    {
        private readonly MovieDemoAPP.Data.MovieDemoAPPContext _context;

        public CreateModel(MovieDemoAPP.Data.MovieDemoAPPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public movie movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.movie == null || movie == null)
            {
                return Page();
            }

            _context.movie.Add(movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
