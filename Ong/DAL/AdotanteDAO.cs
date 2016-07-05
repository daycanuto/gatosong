using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ong.Model;

namespace Ong.DAL
{
    class AdotanteDAO
    {
        private static Context ctx = new Context();

        public static bool AdicionarAdotante(Adotante a)
        {
            try
            {
                ctx.Adotante.Add(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Adotante VerificarAdotantePorCPF(Adotante a)
        {
            return ctx.Adotante.FirstOrDefault(x => x.AdotanteCpf.Equals(a.AdotanteCpf));
        }

        public static bool RemoverAdotante(Adotante a)
        {
            try
            {
                ctx.Adotante.Remove(a);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AlterarAdotante(Adotante a)
        {
            try
            {
                ctx.Entry(a).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static List<Adotante> ListarAdotantes()
        {
            return ctx.Adotante.ToList();
        }

    }
}
