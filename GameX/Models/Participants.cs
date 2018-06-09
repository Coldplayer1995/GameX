using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Models
{
    public class Participants
    {
       
        public int EventID { get; set; }

        public int UserID { get; set; }

        public virtual Events Events { get; set; }

        public virtual Users Users { get; set; }

    }
}
