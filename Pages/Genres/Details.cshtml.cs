using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project_CIDM_3312.Models;

namespace final_project_CIDM_3312.Pages_Genres
{
    public class DetailsModel : PageModel
    {
        private readonly final_project_CIDM_3312.Models.AppDbContext _context;

        public DetailsModel(final_project_CIDM_3312.Models.AppDbContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = await _context.Genres.FirstOrDefaultAsync(m => m.GenreID == id);

            if (genre is not null)
            {
                Genre = genre;

                return Page();
            }

            return NotFound();
        }
    }
}
