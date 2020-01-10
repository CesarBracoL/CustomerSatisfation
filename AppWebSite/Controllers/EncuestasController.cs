using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppWebSite.Models;
using AppWebSite.Helpers;

namespace AppWebSite.Controllers
{
    public class EncuestasController : Controller
    {
        private readonly dbContext _context;

        public EncuestasController(dbContext context)
        {
            _context = context;
        }

        // GET: Encuestas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Encuesta.ToListAsync());
        }

        

        // GET: Encuestas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Encuestas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Enemail,Ennombre,Encalificacion")] Encuesta encuesta)
        {
            if (ModelState.IsValid)
            {
                encuesta.Enfecha =  DateTime.Now.Date;
                Encuesta record = _context.Encuesta.FindAsync(encuesta.Enfecha, encuesta.Enemail).Result;
                if (ServicesEncuesta.puedeRegistrar(record, encuesta))
                {
                    _context.Add(encuesta);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Mensaje = "El email ya está ha registrado una calificacion el día de hoy.";
                    return View();
                }

            }
            return View(encuesta);
        }
    }
}
