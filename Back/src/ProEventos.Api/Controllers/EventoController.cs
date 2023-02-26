using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Data;
using ProEventos.Api.Models;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return this._context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return this._context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post Evento";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put Evento {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete Evento {id}";
        }
    }
}