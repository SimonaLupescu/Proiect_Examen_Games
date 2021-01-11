using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Examen_Games.Data;
using Proiect_Examen_Games.Models;

namespace Proiect_Examen_Games.Pages.Games
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Examen_Games.Data.Proiect_Examen_GamesContext _context;

        public CreateModel(Proiect_Examen_Games.Data.Proiect_Examen_GamesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
