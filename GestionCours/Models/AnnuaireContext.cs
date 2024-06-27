using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCours.Models
{
    internal class AnnuaireContext
    {
        public List<Diplome> Diplomes { get; } = new List<Diplome>();
        public List<Promotion> Promotions { get; } = new List<Promotion>();
        public List<Eleve> Eleves { get; } = new List<Eleve>();

        public AnnuaireContext()
        {
            Diplome TS = new Diplome { Code = "TS", Nom = "Terminal S", Niveau = 5 };
            Diplome BTDW = new Diplome { Code = "BTDW", Nom = " BTS Développeur Web et Web Mobile", Niveau = 5 };
            Diplome BTASR = new Diplome { Code = "BTASR", Nom = " BTS Administrateur Système et Réseau", Niveau = 6 };
            Diplome LICDA = new Diplome { Code = "LICDA", Nom = " Licence Concepteur Développeur d'Applications", Niveau = 8 };
            Diplome MASESD = new Diplome { Code = "MASESD", Nom = " Master Expert en Sécurité Digitale", Niveau = 10 };
            Diplome MASMS2D = new Diplome { Code = "MASMS2D", Nom = " MAster Manager de Solutions Digitales et Data", Niveau = 7 };
            Diplomes.Add(TS);
            Diplomes.Add(BTDW);
            Diplomes.Add(BTASR);
            Diplomes.Add(LICDA);
            Diplomes.Add(MASESD);
            Diplomes.Add(MASMS2D);

            Promotion NCDA_006 = new Promotion { Id = 1, Nom = "NCDA_006", Debut = DateTime.Parse("07/10/2019", new CultureInfo("fr-FR")), Fin = DateTime.Parse("27/08/2021", new CultureInfo("fr-FR")), Diplome = LICDA };
            Promotion NCDA_007 = new Promotion { Id = 2, Nom = "NCDA_007", Debut = DateTime.Parse("12/10/2020", new CultureInfo("fr-FR")), Fin = DateTime.Parse("26/08/2022", new CultureInfo("fr-FR")), Diplome = LICDA };
            Promotion NCDA_008 = new Promotion { Id = 3, Nom = "NCDA_008", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = LICDA };
            Promotion NASR_008 = new Promotion { Id = 4, Nom = "NASR_008", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("14/07/2023", new CultureInfo("fr-FR")), Diplome = BTASR };
            Promotion MS2D_001 = new Promotion { Id = 5, Nom = "MS2D_001", Debut = DateTime.Parse("11/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("15/10/2022", new CultureInfo("fr-FR")), Diplome = MASMS2D };
            Promotion NESD_001 = new Promotion { Id = 6, Nom = "NESD_001", Debut = DateTime.Parse("04/10/2021", new CultureInfo("fr-FR")), Fin = DateTime.Parse("07/10/2022", new CultureInfo("fr-FR")), Diplome = MASESD };
            Promotions.Add(NCDA_006);
            Promotions.Add(NCDA_007);
            Promotions.Add(NCDA_008);
            Promotions.Add(NASR_008);
            Promotions.Add(MS2D_001);
            Promotions.Add(NESD_001);
            BTASR.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(BTASR)).ToList());
            LICDA.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(LICDA)).ToList());
            MASESD.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(MASESD)).ToList());
            MASMS2D.Promotions.AddRange(Promotions.Where(p => p.Diplome.Equals(MASMS2D)).ToList());

            Eleve AMARTIN = new Eleve { Id = 1, Nom = "MARTIN", Prenom = "Alexis", Adresse = "19 avenue Léo Lagrange", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_007 };
            Eleve CDUPONT = new Eleve { Id = 2, Nom = "DUPONT", Prenom = "Claire", Adresse = "2 avenue de Limoges", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_007 };
            Eleve AAUBIN = new Eleve { Id = 3, Nom = "AUBIN", Prenom = "Adèle", Adresse = "6 rue Alphonse Farault", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_008 };
            Eleve GCOLLIN = new Eleve { Id = 4, Nom = "COLLIN", Prenom = "Grégoire", Adresse = "18 rue de l'Hôtel de ville", CodePostal = "79180", Ville = "Chauray", Promotion = NCDA_008 };
            Eleve IBOISVERT = new Eleve { Id = 5, Nom = "BOISVERT", Prenom = "Isabelle", Adresse = "352 avenue de La Rochelle", CodePostal = "79000", Ville = "Niort", Promotion = NCDA_008 };
            Eleve YMIRON = new Eleve { Id = 6, Nom = "MIRON", Prenom = "Yvan", Adresse = "6 rue de la ferme", CodePostal = "79450", Ville = "Saint-Aubin-le-Cloud", Promotion = NESD_001 };
            Eleve MLETOURNEAU = new Eleve { Id = 7, Nom = "LETOURNEAU", Prenom = "Margaux", Adresse = "12 rue de l'ancienne Poudrière", CodePostal = "79000", Ville = "Bessines", Promotion = MS2D_001 };
            NCDA_007.Eleves.Add(AMARTIN);
            NCDA_007.Eleves.Add(CDUPONT);
            NCDA_008.Eleves.Add(AAUBIN);
            NCDA_008.Eleves.Add(GCOLLIN);
            NCDA_008.Eleves.Add(IBOISVERT);
            NESD_001.Eleves.Add(YMIRON);
            MS2D_001.Eleves.Add(MLETOURNEAU);

            Eleves.Add(AMARTIN);
            Eleves.Add(CDUPONT);
            Eleves.Add(AAUBIN);
            Eleves.Add(GCOLLIN);
            Eleves.Add(IBOISVERT);
            Eleves.Add(YMIRON);
            Eleves.Add(MLETOURNEAU);
        }
    }
}
