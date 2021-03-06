using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [Required]
      
        public DateTime ReleaseDate { get; set; }
        [Range(1, 20)]
        [Required]
        [Display(Name="Number In Stock")]
        public int NumberInStock { get; set; } 
    }
}