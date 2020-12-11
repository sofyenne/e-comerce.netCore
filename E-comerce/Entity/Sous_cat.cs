using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Entity
{
    public class Sous_cat
    {
        [Key]
        public int Sous_catId { get; set; }
        public string nom_cat { get; set; }


        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }

     
        public List<Produit> produits { get; set; }

    }
}
