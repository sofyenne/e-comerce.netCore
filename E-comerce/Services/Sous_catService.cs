using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class Sous_catService : Isous_cat

    {
        private readonly AppSettings _appSettings;
        Datacontextcs db;
        private List<Sous_cat> scategorie;

        public Sous_catService(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
            db = _db;
            scategorie = new List<Sous_cat>();
        }




        public Sous_cat Creation(Sous_cat soucat)
        {
            db.Sous_Cats.Add(soucat);
            db.SaveChanges();
            return soucat;

        }

        public IEnumerable<Sous_cat> GetAllS()
        {
            return db.Sous_Cats.Include(c => c.Categorie).ToList();

        }

    }
}