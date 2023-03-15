// See https://aka.ms/new-console-template for more information
using Tarefa;

Console.WriteLine("Hello, World!");

//Cliente p1 = new Cliente(1, "Izabelli", "16981605789", e1);
//Console.WriteLine(p1.getNome() + " " + p1.getTelefone() + " " + p1.getId());

Endereco e1 = new Endereco(
    "Izabelli Anselmo",
    "699",
    "15900057",
    "Centro",
    "Taquaritinga",
    "SP");

Cliente c1 = new Cliente(1, "Felipe", "54789000", e1);
Cliente c2 = new Cliente(2, "Fernanda", "789446985", e1);
Cliente c3 = new Cliente(3, "Mateus", "145621317", e1);
Cliente c4 = new Cliente(4, "Felipe", "231874663", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Moraes");

Console.WriteLine(c1.getEndereco().getRua());

Carro car = new Carro();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.cor = "Vermelho";
car.quantidadeAcentos = 5;
car.PagaImposto = true;


Aviao aviao = new Aviao();
aviao.portasInternas = 50;
aviao.numeroPortas = 1;
aviao.numeroRodas = 3;
aviao.cor = "Branco";
aviao.quantidadeAcentos = 500;
aviao.PagaImposto = false;


Bike bicicleta = new Bike();
bicicleta.PagaImposto = false;

Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

