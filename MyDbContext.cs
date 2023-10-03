using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WerkenMetData.Modellen;

namespace WerkenMetData
{
    public class MyDbContext:DbContext
    {
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<KlantenCategorie> KlantenCategorieen { get; set; }


        public void InitiateDatabase()
        {
            KlantenCategorie kc = new KlantenCategorie { Naam = "Dummy" };
            if (!KlantenCategorieen.Any())
            {
                KlantenCategorieen.Add(kc);
            }
            else
            {
                kc = KlantenCategorieen.First();
            }

            if (!Klanten.Any())
            {
                Klant klant = new Klant() { Geboortedatum = DateTime.Now, Naam = "Dummy", Voornaam = "-" , Categorie = kc};
                Klanten.Add(klant);
            }
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=(localDb)\EvenTesten;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
    }
}
