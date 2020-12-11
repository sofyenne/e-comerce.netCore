using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface ICategorieService
    {
        IEnumerable<Categorie> GetAll();
        Categorie creatcat(Categorie categorie);

    }
}
