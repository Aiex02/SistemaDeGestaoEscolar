using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvd2
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string Professor { get; set; }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Professor: {Professor}");
        }
    }
}
