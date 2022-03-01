#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CelestesFavouriteMusicians.Models;

    public class CelestesFavouriteMusiciansContext : DbContext
    {
        public CelestesFavouriteMusiciansContext (DbContextOptions<CelestesFavouriteMusiciansContext> options)
            : base(options)
        {
        }

        public DbSet<CelestesFavouriteMusicians.Models.Musicians> Musicians { get; set; }
    }
