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
    public class DeleteModel : PageModel
    {
        private readonly CelestesFavouriteMusiciansContext _context;

        public DeleteModel(CelestesFavouriteMusiciansContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musicians = await _context.Musicians.FindAsync(id);

            if (Musicians != null)
            {
                _context.Musicians.Remove(Musicians);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
// Class
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8602
#pragma warning restore CS8604