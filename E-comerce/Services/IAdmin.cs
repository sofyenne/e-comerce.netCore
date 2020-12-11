using E_comerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Services
{
    public interface IAdmin
    {
        Users GetById(int id);
        IEnumerable<Users> GetAllArtisan();

        IEnumerable<Users> GetAll();

        void updateuser(int id);
    }
}
