using GameX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.ViewModel
{
    public class EventViewModel
    {
        public List<Events> Events { get; set; }

    }
    public class EventInputModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public DateTime Date { get; set;}
        public string HouseNumber { get; set; }
        public string PostCode { get; set; } 
    }
}
