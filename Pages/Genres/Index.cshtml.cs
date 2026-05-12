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
    public class IndexModel : PageModel
    {
        private readonly final_project_CIDM_3312.Models.AppDbContext _context;

        public IndexModel(final_project_CIDM_3312.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Genre> Genre { get;set; } = default!;

                // Search support
        [BindProperty(SupportsGet = true)]
        public string CurrentSearch {get; set;} = string.Empty;

        // Pagination
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        public int TotalPages {get; set;}

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;

        public async Task OnGetAsync()
        {
            //Genre = await _context.Genres.ToListAsync();

            var query = _context.Genres.Include(p => p.GameGenres!).ThenInclude(gg => gg.Game).Select(g => g);

            if (!string.IsNullOrEmpty(CurrentSearch))
            {
                //query = query.Where(p => p.CustomerName.Contains(CurrentSearch));
                query = query.Where(g => g.GenreName.ToUpper().Contains(CurrentSearch.ToUpper()));
            }

            switch (CurrentSort)
            {
                case "name_first_asc":
                    query = query.OrderBy(g => g.GenreName);
                    break;
                case "name_first_desc":
                    query = query.OrderByDescending(g => g.GenreName);
                    break;
            }

            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            Genre = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
