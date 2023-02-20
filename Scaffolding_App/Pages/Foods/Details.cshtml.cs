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
    public class DetailsModel : PageModel
    {
        private readonly Scaffolding_App.Data.ApplicationDbContext _context;

        public DetailsModel(Scaffolding_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Food Food { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Foods == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }
            else 
            {
                Food = food;
            }
            return Page();
        }
    }
}
