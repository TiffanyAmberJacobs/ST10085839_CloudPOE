using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static TheRideYouRent.Models.Car;

namespace TheRideYouRent.Models
{
    [MetadataType(typeof(CarMetaData))]
    public partial class Car
    {
        public class CarMetaData
        {
            [DisplayName("CarNo")]
            public string CarNo { get; set; }
            
            [DisplayName("Car Make")]
            public string CarMake { get; set; }

            [DisplayName("Car Model")]
            public string Model { get; set; }

            [DisplayName("Body Type")]
            public string BodyType { get; set; }

            [DisplayName("Kilometres Traveled")]
            public int KilometresTraveled { get; set; }

            [DisplayName("Service Kilometres")]
            public int ServiceKilometres { get; set; }

            [DisplayName("Available")]
            public string Available { get; set; }
            
        }

    }
}