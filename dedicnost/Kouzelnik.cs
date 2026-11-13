namespace Dedicnost
{
    public class Kouzelnik : Postava
    {
        private int mana;

        public int Mana
        {
            get { return mana; }
            private set { mana = value; }
        }
        
        public int ManaMax { get; private set; }
        public Kouzelnik(int id, string jmeno, int mana, int manaMax) : base(jmeno, id)
        {
            Mana = mana;
            ManaMax = manaMax;
        }
        public override void Utoc()
        {
            if (mana > 10)
            {
                Console.WriteLine("Kouzelník střílí arcane blast!");
                mana = mana - 10;
            }
            else
            {
                Console.WriteLine("Kouzelník nemá dostatek many na kouzlení!");
            }

        }

        
        public void Meditace()
        {
            Console.WriteLine("Kouzelník medituje a obnovuje manu co 2 sekundy.");
            while (mana < ManaMax)
            {
                Thread.Sleep(2000);
                Mana = Math.Min(Mana + 10, ManaMax);
                Console.WriteLine("Kouzelník má nyní " + mana + " many.");
            }
            
            mana = ManaMax;
            Console.WriteLine("Kouzelník má nyní plnou manu.");
        }
    }
}