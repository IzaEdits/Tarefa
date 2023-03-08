using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa
{
    public class Pessoa
    {
        public int Id;
        public string Nome;
        public string Telefone;

        public Pessoa(string nome, string telefone, int id)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public int getId()
        {
            return Id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string getTelefone()
        {
            return Telefone;
        }







    }
}
