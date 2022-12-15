namespace Exercism.Exercises {
    abstract class Character {
        private string CharacterType;

        protected Character(string characterType) {
            CharacterType = characterType;
        }

        public virtual bool Vulnerable() {
            return false;
        }

        public abstract int DamagePoints(Character target);

        public override string ToString() {
            return $"Character is a {CharacterType}";
        }

        public static void Executar() {
            var warrior = new Warrior();
            Console.WriteLine(warrior.ToString());
        }
    }

    class Warrior : Character {
        public Warrior() : base("Warrior") {

        }

        public override int DamagePoints(Character target) {
            return target.Vulnerable() ? 10 : 6;
        }
    }

    class Wizard : Character {
        private bool SpellIsPrepared = false;

        public Wizard() : base("Wizard") {

        }

        public void PrepareSpell() {
            SpellIsPrepared = true;
        }

        public override bool Vulnerable() {
            return !SpellIsPrepared;
        }

        public override int DamagePoints(Character target) {
            return SpellIsPrepared ? 12 : 3;
        }
    }
}
