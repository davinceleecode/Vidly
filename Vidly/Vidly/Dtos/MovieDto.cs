using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReleaseDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }


        [Required]
        [Range(1, 20)]
        public int NumberInStock { get; set; }


        public int GenreId { get; set; }
        public GenreDto Genre { get; set; }
    }
}