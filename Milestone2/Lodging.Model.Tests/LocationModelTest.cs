﻿using Lodging.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Lodging.Models.Tests
{
    public class LocationModelTest
    {
        public static readonly IEnumerable<Object[]> _locations = new List<Object[]>
        {
          new object[]
          {
            new LocationModel()
            {
              Id = 0,
              Address = new AddressModel(),
              Latitude = "00",
              Locale = "locale",
              Longitude = "00"
            }
          }
        };

        [Theory]
        [MemberData(nameof(_locations))]
        public void Test_Create_LocationModel(LocationModel location)
        {
            var validationContext = new ValidationContext(location);
            var actual = Validator.TryValidateObject(location, validationContext, null, true);

            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(_locations))]
        public void Test_Validate_LocationModel(LocationModel location)
        {
            var validationContext = new ValidationContext(location);

            Assert.Empty(location.Validate(validationContext));
        }
    }
}