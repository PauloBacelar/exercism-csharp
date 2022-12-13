namespace Exercism.Exercises {
    class RemoteControlCar {
        private static int DistanceDriven;
        private static int Battery;

        public RemoteControlCar() {
            DistanceDriven = 0;
            Battery = 100;
        }

        public static RemoteControlCar Buy() {
            return new RemoteControlCar();
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
            RemoteControlCar car = RemoteControlCar.Buy();

            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            car.Drive();
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());
        }
    }
}
