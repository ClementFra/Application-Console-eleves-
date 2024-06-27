using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Models
{
    internal class Eleve
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Email { get; set; }
        public string Adresse { get; set; }

        public string CodePostal { get; set; }
        public string Ville { get; set; }


        public Promotion Promotion { get; set; }

        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }

    }
}
