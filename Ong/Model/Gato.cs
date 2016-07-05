using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ong.Model
{
    [Table("Gato")]
    class Gato
    {
        [Key]
        public int GatoId { get; set; }
        public int AdocaoId { get; set; }
        public string GatoNome { get; set; }
        public string GatoIdade { get; set; }
        public string GatoCor { get; set; }
        public string GatoStatus { get; set; }
    }
}

//teste