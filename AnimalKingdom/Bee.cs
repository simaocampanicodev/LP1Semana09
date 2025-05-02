namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get; }

        public Bee()
        {
            NumberOfWings = 4;
        }

        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }
    }
}