using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Examen_Games.Models;

namespace Proiect_Examen_Games.Data
{
    public class Proiect_Examen_GamesContext : DbContext
    {
        public Proiect_Examen_GamesContext (DbContextOptions<Proiect_Examen_GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Examen_Games.Models.Game> Game { get; set; }
    }
}
