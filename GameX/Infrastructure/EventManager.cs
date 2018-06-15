﻿using GameX.DAL;
using GameX.HelperClass;
using GameX.Models;
using GameX.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Infrastructure
{
    public class EventManager : IEvent
    {
        private readonly StoreContext context;
        public List<CoordAddress> CoordAddresses { get; set; }
        public EventManager(StoreContext context)
        {
            this.context = context;
            this.CoordAddresses = new List<CoordAddress>();

        }
        public void Add(EventInputModel Event)
        {
            EventAdress eventAdress = new EventAdress
            {
                City = Event.City,
                HouseNumber = Event.HouseNumber,
                PostCode = Event.PostCode,
                Street = Event.Street,

            };
            Events EventRecord = new Events
            {
                Date = Event.Date,
                Coords = null,
                Name = Event.Name,
                Description = Event.Description,

            };
            try
            {
                context.EventAdress.Add(eventAdress);
                context.SaveChanges();
                EventRecord.EventAdressId = eventAdress.EventAdressId;
                context.Events.Add(EventRecord);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void Edit(EventInputModel Event)
        {

            EventAdress eventAdress = new EventAdress
            {
                City = Event.City,
                HouseNumber = Event.HouseNumber,
                PostCode = Event.PostCode,
                Street = Event.Street,
                EventAdressId = (int)Event.EventAdressId

            };
            Events EventRecord = new Events
            {
                Date = Event.Date,
                Coords = null,
                Name = Event.Name,
                EventId = (int)Event.EventId

            };
            try
            {
                context.EventAdress.Update(eventAdress);
                context.SaveChanges();
                EventRecord.EventAdressId = eventAdress.EventAdressId;
                context.Events.Update(EventRecord);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
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

        public List<CoordAddress> getEventsAddress()
        {

            List<EventAdress> Addresses = context.EventAdress.ToList();
            foreach (var adress in Addresses)
            {
                CoordAddress co = new CoordAddress()
                {
                    City = adress.City,
                    HouseNumber = adress.HouseNumber,
                    Street = adress.Street,
                    EventAdressId = adress.EventAdressId
                };
                CoordAddresses.Add(co);

            }
            return CoordAddresses;


        }

        public void SaveCoords(double lat, double lng, int EventAdressId)
        {
            EventAdress EventAddress = context.EventAdress.FirstOrDefault(x => x.EventAdressId == EventAdressId);
            try
            {
                EventAddress.Lat = lat;
                EventAddress.Lng = lng;
                context.EventAdress.Update(EventAddress);
                context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
