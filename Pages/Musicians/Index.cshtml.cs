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
    #pragma warning disable CS8618
    #pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly CelestesFavouriteMusiciansContext _context;

        public IndexModel(CelestesFavouriteMusiciansContext context)
        {
            _context = context;
        }

        public IList<Musicians> Musicians { get;set; }

        public async Task OnGetAsync()
        {
            Musicians = await _context.Musicians.ToListAsync();
        }
    }
    #pragma warning restore CS8618
    #pragma warning restore CS8604
}
