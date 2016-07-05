using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ong.Model
{
    [Table("Adotante")]
    class Adotante
    {
        [Key]
        public int AdotanteId { get; set; }
        public List<Adocao> Adocoes { get; set; }
        public string AdotanteNome { get; set; }
        public string AdotanteCpf { get; set; }
        public string AdotanteIdade { get; set; }
        public string AdotanteEndereço { get; set; }
        public string AdotanteTelefone { get; set; }
    }

}