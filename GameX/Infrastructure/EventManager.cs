using GameX.DAL;
using GameX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Infrastructure
{
    public class EventManager : IEvent
    {
        private readonly StoreContext context;
        public EventManager(StoreContext context)
        {
            this.context = context;
        }
        public void Add(Events Event)
        {
            try
            {
                context.Add(Event);
            }
            catch (Exception ex)
            {

                throw;
            }

            throw new NotImplementedException();
        }

        public void Edit()
        {

            throw new NotImplementedException();
        }
        public void Delete(int EventID)
        {
            Events Event = context.Events.FirstOrDefault(x => x.EventId == EventID);
            try
            {
                context.Events.Remove(Event);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
