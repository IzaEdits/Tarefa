using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa
{
    public class Veiculos
    {
        public int numeroRodas;
        public int numeroPortas;
        public string cor;
        public int quantidadeAcentos;
        public bool PagaImposto;

        public string ExibirDados()
        {
            return "Numero de Portas:" + numeroPortas + " Cor:" + cor;
        }
    }
}
