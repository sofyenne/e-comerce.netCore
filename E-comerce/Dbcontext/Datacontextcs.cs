using E_comerce.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerce.Dbcontext
{
    public class Datacontextcs: DbContext
    {
        public Datacontextcs(DbContextOptions<Datacontextcs> options) : base(options)
        {


        }
        public DbSet<Users> Users { get; set; }
       
        public DbSet<Sous_cat> Sous_Cats { get; set; }

        public DbSet<Categorie> categories { get; set; }

    
       

       
       


    }


}






 
