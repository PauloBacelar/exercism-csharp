using System;
using System.Collections.Generic;

using Exercism.Exercises;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"001 - Hello World", _001HelloWorld.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}