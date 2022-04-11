using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GE.Domain
{
    public class Equipe
    {
        public String AdresseLocal { get; set; }
        [Key]
        public int EquipeId { get; set; }
        public String  Logo { get; set; }
        public String NomEquipe { get; set; }
        public List<Trophee> Trophees { get; set; }
        public List<Contrat> Contrats { get; set; }
    }
}
