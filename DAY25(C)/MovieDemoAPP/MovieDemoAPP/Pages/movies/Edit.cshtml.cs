﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieDemoAPP.Data;
using MovieDemoAPP.model;

namespace MovieDemoAPP.Pages.movies
{
    public class EditModel : PageModel
    {
        private readonly MovieDemoAPP.Data.MovieDemoAPPContext _context;

        public EditModel(MovieDemoAPP.Data.MovieDemoAPPContext context)
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

            var movie =  await _context.movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            movie = movie;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!movieExists(movie.Id))
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

        private bool movieExists(int id)
        {
          return (_context.movie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
