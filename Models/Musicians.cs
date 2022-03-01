using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CelestesFavouriteMusicians.Models
{
    public class Musicians
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Number of Albums")]
        public int NumberOfAlbums { get; set; }

        [Display(Name = "Number of Awards")]
        public int NumberOfAwards { get; set; }
    }
}