﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employee.Data;
using Employee.Model;

namespace Employee.Pages.office
{
    public class DeleteModel : PageModel
    {
        private readonly Employee.Data.EmployeeContext _context;

        public DeleteModel(Employee.Data.EmployeeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Emp Emp { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Emp == null)
            {
                return NotFound();
            }

            var emp = await _context.Emp.FirstOrDefaultAsync(m => m.Id == id);

            if (emp == null)
            {
                return NotFound();
            }
            else 
            {
                Emp = emp;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Emp == null)
            {
                return NotFound();
            }
            var emp = await _context.Emp.FindAsync(id);

            if (emp != null)
            {
                Emp = emp;
                _context.Emp.Remove(Emp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
