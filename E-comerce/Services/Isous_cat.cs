using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface Isous_cat
    {
        IEnumerable<Sous_cat> GetAllS();
        Sous_cat Creation(Sous_cat soucat);
    }
}
