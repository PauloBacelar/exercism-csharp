using System;
using System.Collections.Generic;

using Exercism.Exercises;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"001 - Hello World", HelloWorld.Executar},
                {"002 - Lucian's Luscious Lasagna", LusciousLasagna.Executar},
                {"003 - Annalyn's Infiltration", QuestLogic.Executar},
                {"004 - Cars, Assmeble!", AssemblyLine.Executar},
                {"005 - Log Levels", LogLine.Executar},
                {"006 - Elon's Toys", RemoteControlCar2.Executar},
                {"007 - Interest is Interesting", SavingsAccount.Executar},
                {"008 - Bird Watcher", BirdCount.Executar},
                {"009 - Squeaky Clean", Identifier.Executar},
                {"010 - Need for Speed", RemoteControlCar.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}