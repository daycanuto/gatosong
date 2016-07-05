using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ong.Model;

namespace Ong.DAL
{
    class Context : DbContext
    {
        public DbSet<Adotante> Adotante { get; set; }
        public DbSet<Gato> Gato { get; set; }
        public DbSet<Adocao> Adocao { get; set; }
    }
}
