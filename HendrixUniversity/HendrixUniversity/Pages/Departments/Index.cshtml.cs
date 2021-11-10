using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HendrixUniversity.Data;
using HendrixUniversity.Models;

namespace HendrixUniversity.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly HendrixUniversity.Data.SchoolContext _context;

        public IndexModel(HendrixUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Departments
                .Include(d => d.Administrator).ToListAsync();
        }
    }
}
