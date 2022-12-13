using System.Runtime.InteropServices;

namespace Exercism.Exercises {
    class BirdCount {
        private int[] WeekCount;

        public BirdCount(int[] weekCount) {
            WeekCount = weekCount;
        }

        public static int[] LastWeek() {
            int[] x = { 0, 2, 5, 3, 7, 8, 4 };
            return x;
        }

        public int Today() {
            return WeekCount[WeekCount.Length - 1];
        }

        public void IncrementTodaysCount() {
            WeekCount[WeekCount.Length - 1]++;
        }

        public bool HasDayWithoutBirds() {
            foreach(int count in WeekCount) {
                if (count == 0) {
                    return true;
                }
            }

            return false;
        }

        public int CountForFirstDays(int limit) {
            int soma = 0;

            for(int i = 0; i  < limit; i++) {
                soma += WeekCount[i];
            }

            return soma;
        }

        public int BusyDays() {
            int numberOfBusyDays = 0;

            for(int i = 0; i < WeekCount.Length; i++) {
                if (WeekCount[i] >= 5) {
                    numberOfBusyDays++;
                }
            }

            return numberOfBusyDays;
        }

        public static void Executar() {
            Console.WriteLine(BirdCount.LastWeek());

            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            Console.WriteLine(birdCount.Today());
            Console.WriteLine(birdCount.HasDayWithoutBirds());
            Console.WriteLine(birdCount.CountForFirstDays(4));
            Console.WriteLine(birdCount.BusyDays());
        }
    }
}
