using GestionCours.Models;

namespace GestionCours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnnuaireContext context = new AnnuaireContext();
            Console.WriteLine("Liste des diplômes sans promotion:");
            context.Diplomes.Where(d=> d.Promotions.Count == 0).ToList().ForEach(d=> Console.WriteLine($"-{d}"));

            Console.WriteLine("Nombre d'élèves par promotion:");
            context.Promotions.Where(p=> p.Eleves.Count>0).ToList().ForEach(p=> Console.WriteLine($"-{p.Nom}: {p.Eleves.Count} élèves"));

            Promotion promotionAvecPLusDEleves= context.Promotions.OrderByDescending(p=> p.Eleves.Count).FirstOrDefault();
            Console.WriteLine($"Promotion avec le plus d'élèves: {promotionAvecPLusDEleves}");

            Console.WriteLine("Elèves qui passent le titre Licence Concepteur Développeur d'Applications:");
            context.Eleves.Where(e => e.Promotion.Diplome.Code.Equals("Licence Concepteur Développeur d'Applications")).ToList().ForEach(e=> Console.WriteLine($"-{e}"));
        }
    }
}
