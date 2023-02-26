using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Models;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEnumerable<Evento> _eventos = new Evento[] {
            new Evento{
                EventoId = 1,
                Tema = "Tema 1",
                Local = "Local 1",
                Lote = "1",
                QtdPessoas = 100,
                DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                ImagemUrl = "Imagem1.png"
            },
            new Evento{
                EventoId = 2,
                Tema = "Tema 2",
                Local = "Local 2",
                Lote = "2",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Imagem2.png"
            }
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(e => e.EventoId == id);
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