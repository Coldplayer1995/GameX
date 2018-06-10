﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Coords { get; set; }

        public virtual EventAdress EventAdress { get; set; }

        
    }
}
