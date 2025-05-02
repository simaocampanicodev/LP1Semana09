namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get; }
        public int NumberOfWings { get; }

        public Bat()
        {
            NumberOfWings = 2;
            NumberOfNipples = 2;
        }

        public override string Sound()
        {
            return base.Sound() + "Ti ti ti";
        }
    }
}