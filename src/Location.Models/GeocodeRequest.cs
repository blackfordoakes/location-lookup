using System;

namespace Location.Models
{
    public class GeocodeRequest
    {
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Region { get; set; }
    }
}
