using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class CustomRequiredMovieReleaseDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.ReleaseDate == null || movie.ReleaseDate.Value.ToString() == "")
                return new ValidationResult("Release Date is required.");


            return ValidationResult.Success;

        }
    }
}