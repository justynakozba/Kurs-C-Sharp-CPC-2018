using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustynaKozbaLab4.Model
{
    public class Review :Entity
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Score { get; set; }
        //klucz obcy w polu Game
        [ForeignKey("GameId")]
        public virtual Game Game { get; set; }
        public int GameId { get; set; }

    }
}
