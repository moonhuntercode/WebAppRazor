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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie2> Movie2 { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie2 != null)
            {
                Movie2 = await _context.Movie2.ToListAsync();
            }
        }
    }
}
