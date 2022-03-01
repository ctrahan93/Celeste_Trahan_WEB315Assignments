#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CelestesFavouriteMusicians.Models;

namespace CelestesFavouriteMusicians.Pages_Musicians
{
    public class EditModel : PageModel
    {
        private readonly CelestesFavouriteMusiciansContext _context;

        public EditModel(CelestesFavouriteMusiciansContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Musicians).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusiciansExists(Musicians.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MusiciansExists(int id)
        {
            return _context.Musicians.Any(e => e.ID == id);
        }
    }
}
