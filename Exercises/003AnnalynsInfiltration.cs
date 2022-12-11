namespace Exercism.Exercises {
    class QuestLogic {
        public static bool CanFastAttack(bool knightIsAwake) {
            return !knightIsAwake;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) {
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) {
            return prisonerIsAwake && !archerIsAwake;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool dogIsPresent) {
            if (dogIsPresent) {
                return !archerIsAwake;
            } else {
                return prisonerIsAwake && (!archerIsAwake && !knightIsAwake);
            }
        }

        public static void Executar() {
            Console.WriteLine(QuestLogic.CanFastAttack(true));
            Console.WriteLine(QuestLogic.CanSpy(false, true, false));
            Console.WriteLine(QuestLogic.CanSignalPrisoner(false, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, true, false, false));
        }
    }
}
