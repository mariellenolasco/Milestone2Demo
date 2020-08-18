using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lodging.Models
{
    /// <summary>
    /// This represents the address model of the api
    /// </summary>
    public class AddressModel : IValidatableObject
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string StateProvince { get; set; }

        public string Street { get; set; }

        /// <summary>
        /// Navigation properties
        /// </summary>
        public int? LocationId { get; set; }

        public LocationModel Location { get; set; }

        /// <summary>
        /// This is the object's validate method, returns all validation errors in a list that the end user can go through
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new List<ValidationResult>();
    }
}
