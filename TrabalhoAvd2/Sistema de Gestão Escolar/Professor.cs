﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvd2
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }
        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Idade: {Idade}, Disciplina: {Disciplina}");
        }
    }
}
