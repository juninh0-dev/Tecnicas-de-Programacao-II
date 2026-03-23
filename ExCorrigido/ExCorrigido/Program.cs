using ExCorrigido;

Fabrica fabrica1 = new Fabrica("Fabrica de Chocolate", "modelo1", "1000", "Máquina acabou de chegar.", "Máquina 1",new DateTime(12/10/2025));

fabrica1.AdicionarMaquina("modelo2", "2000", "Máquina Nova", "Máquina 2", new DateTime(12/11/2025));
fabrica1.AdicionarMaquina("modlo2", "3000", "Máquina Nova", "Máquina 2", new DateTime(12/11/2025));

fabrica1.ListarMaquinas();
Maquina maquina1 = new Maquina("Modelo 5", "5000", "Máquina do Operador", "Operador 5", new DateTime(2026, 4, 1));
Operador operador1 = new Operador("Pernalonga", maquina1);
await operador1.OperarMaquinasAsync(fabrica1, "modelo1");
Console.ReadKey();