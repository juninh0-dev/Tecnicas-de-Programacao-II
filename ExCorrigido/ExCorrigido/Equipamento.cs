using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExCorrigido
{
    internal class Equipamento
    {
        public Equipamento(string nome, DateTime dataFabricacao) {
            Nome = nome;
            DataFabricacao = dataFabricacao;
        
        }
        public string? Nome { get; set; }
        public DateTime? DataFabricacao { get; set; }
    }
}
