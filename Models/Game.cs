using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Examen_Games.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        public string Publisher { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime PublishingDate { get; set; }
    }
}
