﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Examen_Games.Data;
using Proiect_Examen_Games.Models;

namespace Proiect_Examen_Games.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Examen_Games.Data.Proiect_Examen_GamesContext _context;

        public DetailsModel(Proiect_Examen_Games.Data.Proiect_Examen_GamesContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
