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
    public class IndexModel : PageModel
    {
        private readonly MovieDemoAPP.Data.MovieDemoAPPContext _context;

        public IndexModel(MovieDemoAPP.Data.MovieDemoAPPContext context)
        {
            _context = context;
        }

        public IList<movie> movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.movie != null)
            {
                movie = await _context.movie.ToListAsync();
            }
        }
    }
}
