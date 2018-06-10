using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameX.DAL;
using Microsoft.AspNetCore.Mvc;

namespace GameX.Controllers
{
    public class EventController : Controller
    {
        private readonly StoreContext _context;
        public EventController(StoreContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public 
    }
}