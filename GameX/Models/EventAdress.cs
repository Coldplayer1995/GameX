using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Models
{
    public class EventAdress
    {
        [Key]
        public int EventAdressId { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string HouseNumber { get; set; }

    }
}
