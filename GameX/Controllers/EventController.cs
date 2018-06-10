using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameX.DAL;
using GameX.Infrastructure;
using GameX.Models;
using GameX.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GameX.Controllers
{
    public class EventController : Controller
    {
        private readonly StoreContext context;
        private IEvent EventManager { get; set; }
        public EventController(StoreContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            EventViewModel Model = new EventViewModel();
            Model.Events = context.Events.ToList();
            return View(Model);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Events Event)
        {
            this.EventManager.Add(Event);
            return View();
        }
        [HttpPost]
        public IActionResult Remove(int EventID)
        {
            this.EventManager.Delete(EventID);
            return View();
        }

    }
}