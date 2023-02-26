using Microsoft.EntityFrameworkCore;
using ProEventos.Api.Models;

namespace ProEventos.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option) : base(option)
        {
            
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}