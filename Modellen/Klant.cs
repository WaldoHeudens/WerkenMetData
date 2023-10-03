using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkenMetData.Modellen
{
    public class Klant
    {
        public int Id { get; set; }
        
        [StringLength(maximumLength:50)]
        public string Naam { get; set; }

        [StringLength(maximumLength: 50)]
        public string Voornaam { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }

        [ForeignKey("KlantenCategorien")]
        public int CategorieId { get; set; }

        public KlantenCategorie? Categorie { get; set; }
    }
}
