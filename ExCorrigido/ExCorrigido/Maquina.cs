using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCorrigido
{
    class Maquina : Equipamento // Aqui estou falando de quem ele vai herdar
    {
        //Criando o método construtor
        public Maquina(string modelo, string horaOperacao, string obs, string? nome, DateTime dataFabricacao):base(nome, dataFabricacao) {
            Modelo = modelo;
            HoraOperacao = horaOperacao;
            Observacao = obs;
            
        }
        public string? Modelo {  get; set; }
        public string? HoraOperacao { get; set; }
        //Número de série não pode estar no contrutor, pois não contém "set" e é só de leitura
        private Guid numeroSerie = new Guid();
        public Guid NumeroSerie { 
            get { return NumeroSerie; } 
        }
        private string? observacao;
        public string? Observacao { 
            set { observacao = value; } 
        }
    }
}
