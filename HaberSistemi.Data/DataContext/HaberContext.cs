using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaberSistemi.Data.Model;

namespace HaberSistemi.Data.DataContext
{
   public class HaberContext :DbContext
    {
        public HaberContext() : base("Name=HaberContext"){ }
       

        public  DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Role> Rol { get; set; }

    }
}
