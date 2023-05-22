using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieDemoAPP.Data;
using MovieDemoAPP.model;

namespace MovieDemoAPP.Pages.movies
{
    public class DeleteModel : PageModel
    {
        private readonly MovieDemoAPP.Data.MovieDemoAPPContext _context;

        public DeleteModel(MovieDemoAPP.Data.MovieDemoAPPContext context)
        {
            _context = context;
        }

        [BindProperty]
      public movie movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.movie == null)
            {
                return NotFound();
            }

            var movie = await _context.movie.FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                movie = movie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.movie == null)
            {
                return NotFound();
            }
            var movie = await _context.movie.FindAsync(id);

            if (movie != null)
            {
                movie = movie;
                _context.movie.Remove(movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
