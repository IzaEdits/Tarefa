// See https://aka.ms/new-console-template for more information
using Tarefa;

Console.WriteLine("Hello, World!");

Cliente p1 = new Cliente("Izabelli", "16981605789", 1);
Console.WriteLine(p1.getNome() + " " + p1.getTelefone() + " " + p1.getId());