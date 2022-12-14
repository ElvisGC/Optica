using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Optica.Models;
using Optica.Data;

namespace Optica.Controllers
{
    
    public class ContactanosController : Controller
    {
        private readonly ILogger<ContactanosController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactanosController(ILogger<ContactanosController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Contactanos()
        {
            return View();
        }

        public IActionResult Index()
        {
            var listacontactanos = _context.Contactanos.ToList();
            ViewData["message"]="";
            return View(listacontactanos);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        public IActionResult Create(Contactanos objContactanos)
        {
            _context.Add(objContactanos);
            _context.SaveChanges();
            ViewData["Message"] = "El Mensaje fue enviado con éxito";
            return View();
        }

    
    }
}
