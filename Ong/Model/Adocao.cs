using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ong.Model
{
    [Table("Adocoes")]

    class Adocao
    {
        [Key]
        public int AdocaoId { get; set; }
        public int AdotanteId { get; set; }
        public int GatoId { get; set; }
    }
}
