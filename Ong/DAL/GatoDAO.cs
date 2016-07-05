using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ong.Model;

namespace Ong.DAL
{
    class GatoDAO
    {
        private static Context ctx = new Context();
        

        public static bool AdicionarGato(Gato g)
        {
            try
            {
                ctx.Gato.Add(g);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Gato VerificarGatoPorNome(Gato g)
        {
            return ctx.Gato.FirstOrDefault(x => x.GatoNome.Equals(g.GatoNome));
        }

        public static Gato VerificarGatoPorId(int id)
        {
            return ctx.Gato.FirstOrDefault(x => x.GatoId.Equals(id));
        }

        public static bool RemoverGato(Gato g)
        {
            try
            {
                ctx.Gato.Remove(g);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AlterarGato(Gato g)
        {
            try
            {
                ctx.Entry(g).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static List<Gato> ListarGatoLivres()
        {
            return ctx.Gato.Where(x => x.GatoStatus.Equals("Livre")).ToList();
        }

    }
}
