using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class CustomRequiredMovieInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock == null || movie.NumberInStock.Value.ToString() == "")
                return new ValidationResult("Number in Stock is required.");

            return ValidationResult.Success;
        }
    }
}