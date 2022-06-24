using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppRazor.Models;

namespace WebAppRazor.Pages_Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

      public Movie2 Movie2 { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie2 == null)
            {
                return NotFound();
            }

            var movie2 = await _context.Movie2.FirstOrDefaultAsync(m => m.ID == id);
            if (movie2 == null)
            {
                return NotFound();
            }
            else 
            {
                Movie2 = movie2;
            }
            return Page();
        }
    }
}
