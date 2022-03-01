#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CelestesFavouriteMusicians.Models;

namespace CelestesFavouriteMusicians.Pages_Musicians
{
    public class DetailsModel : PageModel
    {
        private readonly CelestesFavouriteMusiciansContext _context;

        public DetailsModel(CelestesFavouriteMusiciansContext context)
        {
            _context = context;
        }

        public Musicians Musicians { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musicians = await _context.Musicians.FirstOrDefaultAsync(m => m.ID == id);

            if (Musicians == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
