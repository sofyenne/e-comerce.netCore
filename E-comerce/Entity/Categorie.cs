 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        public  string nom_cat { get; set; }
        public List<Sous_cat> sous_Cats { get; set; }



    }
    
}
