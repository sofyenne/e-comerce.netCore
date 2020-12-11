using E_comerce.Entity;
using System.Collections.Generic;

namespace E_comerce.Services
{
    public interface IUserService
    {
        Users Create(Users user, string password);
        Users Authenticate(string email, string password);
        IEnumerable<Users> GetAll();
        Users GetById(int id);
        Users creatArisan(Users user, string password);
    }
}