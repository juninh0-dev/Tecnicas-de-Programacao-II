using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Maquina
    {
        public string? Modelo { get; set; }
        public string? HoraOperacao { get; set; }
        public Guid NumeroSerie { set; }
        public string? Observacao  { get; }
        
    }
}
