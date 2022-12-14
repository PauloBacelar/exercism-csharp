namespace Exercism.Exercises {
    class RemoteControlCar2 {
        private static int DistanceDriven;
        private static int Battery;

        public RemoteControlCar2() {
            DistanceDriven = 0;
            Battery = 100;
        }

        public static RemoteControlCar2 Buy() {
            return new RemoteControlCar2();
        }

        public string DistanceDisplay() {
            return $"Driven {DistanceDriven} meters";
        }

        public string BatteryDisplay() {
            return Battery > 0 ? $"Battery at {Battery}%" : "Battery empty";
        }

        public void Drive() {
            if (Battery > 0) {
                DistanceDriven += 20;
                Battery -= 1;
            }   
        }

        public static void Executar() {
            RemoteControlCar2 car = RemoteControlCar2.Buy();

            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            car.Drive();
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());
        }
    }
}
