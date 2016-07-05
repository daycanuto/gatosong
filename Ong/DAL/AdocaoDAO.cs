using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ong.Model;

namespace Ong.DAL
{
    class AdocaoDAO
    {
        private static Context ctx = new Context();

        public static bool AdicionarAdocao(Adocao a)
        {
            try
            {
                ctx.Adocao.Add(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
