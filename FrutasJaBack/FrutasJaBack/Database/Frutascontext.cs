using FrutasJaBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrutasJaBack.Database
{
    public class Frutascontext: DbContext
    {

        public Frutascontext(DbContextOptions<Frutascontext> options) : base(options)
        {

        }

        public DbSet<Usuario> Clientes { get; set; }


    }
}
