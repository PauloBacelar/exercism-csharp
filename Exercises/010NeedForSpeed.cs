namespace Exercism.Exercises {
    class RemoteControlCar {
        public int Speed;
        public int BatteryDrain;
        public int DrivenDistance;
        public int Battery;

        public RemoteControlCar(int speed, int batteryDrain) {
            Speed = speed;
            BatteryDrain = batteryDrain;
            DrivenDistance = 0;
            Battery = 100;
        }

        public void Drive() {
            if (Battery - BatteryDrain >= 0) {
                DrivenDistance += Speed;
                Battery -= BatteryDrain;
            }
        }

        public int DistanceDriven() {
            return DrivenDistance;
        }

        public bool BatteryDrained() {
            return Battery - BatteryDrain < 0;
        }

        public static RemoteControlCar Nitro() {
            return new RemoteControlCar(50, 4);
        }

        public static void Executar() {
            var car = new RemoteControlCar(5, 2);
            var raceTrack = new RaceTrack(800);

            car.Drive();
            Console.WriteLine(car.DistanceDriven());
            Console.WriteLine(car.BatteryDrained());
            Console.WriteLine(car.DistanceDriven());

            Console.WriteLine(new RaceTrack(100).TryFinishTrack(car)); 
        }
    }

    class RaceTrack {
        private int Distance;

        public RaceTrack(int distance) {
            Distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar car) {
            return (100 / car.BatteryDrain) * car.Speed >= Distance;
        }
    }
}
