using GameX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Infrastructure
{
    public interface IEvent
    {
        void Add(Events Event);

        void Edit();

        void Delete(int EventID);


    }
}
