using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GE.Domain
{
    public class Trophee
    {
        [DataType(DataType.Date)]
        public DateTime DateTrophee { get; set; }
        [DataType(DataType.Currency)]
        public Double Recompense { get; set; }
        [Key]
        public int TropheeId { get; set; }
        public String TypeTrophee { get; set; }
        public Equipe Equipe { get; set; }
    }
}
