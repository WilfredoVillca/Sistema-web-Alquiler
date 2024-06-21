using Microsoft.EntityFrameworkCore;
using SistemaWeb.Models;
using System.Collections.Generic;

namespace SistemaWeb.Contexto
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Alquiler> Alquilers { get; set; }
    }
}
