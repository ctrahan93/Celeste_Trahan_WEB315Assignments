#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CelestesFavouriteMusicians.Models;

namespace CelestesFavouriteMusicians.Pages_Musicians
{
    public class CreateModel : PageModel
    {
        private readonly CelestesFavouriteMusiciansContext _context;

        public CreateModel(CelestesFavouriteMusiciansContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Musicians Musicians { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Musicians.Add(Musicians);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
