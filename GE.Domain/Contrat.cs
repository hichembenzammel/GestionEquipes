using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GE.Domain
{
    public class Contrat
    {
        public DateTime DateContrat { get; set; }  
        [Range(0,24)]
        public int DureeMois { get; set; }  
        public Double Salaire { get; set; }
        public Membre Membre { get; set; }
        public Equipe Equipe { get; set; }
    }
}
