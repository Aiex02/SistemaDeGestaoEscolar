using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvd2
{
    abstract class Pessoa : IExibir
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}
