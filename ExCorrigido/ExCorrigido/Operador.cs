using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCorrigido
{
    internal class Operador
    {
        //Criando um construtor

        // Associação unilateral
        public Operador(string nome, Maquina maquinaOperador) 
        { 
            Nome = nome;
            MaquinaOperador = maquinaOperador;
        }
        public string? Nome {  get; set; }
        public Maquina? MaquinaOperador { get; set; }
        public async void OperarMaquinasAsync(Fabrica fabrica, string modelo)
        {
            Console.WriteLine($"{Nome} está tentando operar a máquina modelo {modelo}");
            await Task.Delay(2000);
            var maquina = fabrica.BuscarMaquinaPorModelo(modelo);
            if (maquina == null)
            {
                Console.WriteLine($"Máquina modelo {modelo} não encontrada na Fábrica {fabrica.Nome}");
            }
            else
            {
                Console.WriteLine($"{Nome} agora está operando a máquina modelo {maquina.Modelo}");
                await Task.Delay(3000);
            }
        }
    }
}
