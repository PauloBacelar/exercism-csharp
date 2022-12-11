using System;

namespace Exercism.Exercises {
    class Lasagna {
        public Lasagna() { }

        public int ExpectedMinutesInOven() {
            return 40;
        }

        public double RemainingMinutesInOven(double minutesAlreadyInOven) {
            if (minutesAlreadyInOven <= ExpectedMinutesInOven()) {
                return ExpectedMinutesInOven() - minutesAlreadyInOven;
            }

            return 0;
        }

        public int PreparationTimeInMinutes(int numberOfLayers) {
            if (numberOfLayers <= 0) {
                return 0;
            }

            return numberOfLayers * 2;
        }

        public double ElapsedTimeInMinutes(int numberOfLayers, double minutesInOven) {
            if (numberOfLayers <= 0 || minutesInOven < 0) {
                return 0;
            }

            return (numberOfLayers * 2) + minutesInOven;
        }
    }

    class LusciousLasagna {
        public static void Executar() {
            var lasagna = new Lasagna();

            Console.WriteLine(lasagna.ExpectedMinutesInOven());
            Console.WriteLine(lasagna.RemainingMinutesInOven(30));
            Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
        }
    }
}
