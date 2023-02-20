using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scaffolding_App.Data;
using Scaffolding_App.Models;

namespace Scaffolding_App.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly Scaffolding_App.Data.ApplicationDbContext _context;

        public IndexModel(Scaffolding_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Foods != null)
            {
                Food = await _context.Foods.ToListAsync();
            }
        }
    }
}
