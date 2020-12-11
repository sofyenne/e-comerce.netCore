using E_comerce.Dbcontext;
using E_comerce.Entity;
using E_comerce.Setting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public class Adminservicecs : IAdmin
    {
        private readonly AppSettings _appSettings;

        Datacontextcs db;
        private List<Users> users;

        public Adminservicecs(IOptions<AppSettings> appSettings, Datacontextcs _db)
        {
            _appSettings = appSettings.Value;
             db = _db;

        }

        public Users GetById(int id)
        {
            var user = db.Users.FirstOrDefault(x => x.Userid == id);
            return user.WithoutPassword();
        }


      
   
       public IEnumerable<Users>  GetAllArtisan()
        {
          
            return db.Users.WithoutPasswords();
        }

        public IEnumerable<Users> GetAll()
        {
            return db.Users.WithoutPasswords();
        }

        public void updateuser(int id)
        {

            var user = GetById(id);
            user.etat = "validé";
            db.Users.Update(user);
            db.SaveChanges();
        }
    }
}
