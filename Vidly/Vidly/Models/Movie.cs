﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public Movie()
        {
            Id = 0;
        }

        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [CustomRequiredMovieReleaseDate]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ReleaseDate { get; set; }



        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateAdded { get; set; }


        [CustomRequiredMovieInStock]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int? NumberInStock { get; set; }


        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}