using System;
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
    public class IndexModel : PageModel
    {
        private readonly Employee.Data.EmployeeContext _context;

        public IndexModel(Employee.Data.EmployeeContext context)
        {
            _context = context;
        }

        public IList<Emp> Emp { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Emp != null)
            {
                Emp = await _context.Emp.ToListAsync();
            }
        }
    }
}
