namespace Dedicnost
{
    public class FinalBoss : Boss
    {

        public int Pancir { get; private set;}

        public int PocetUtoku { get; private set; } = 0;

        public bool BojovyRezim { get; private set ; } = false;
        public FinalBoss(int id, string jmeno, int zivoty, int pancir) : base(id, jmeno, zivoty)
        {
            Pancir = pancir;
        }
            public override void Utoc()
        {
            PocetUtoku++;
            
            switch (Faze)
            {
                case 1:
                    Console.WriteLine($"boss útočí mečem!");
                    break;
                case 2:
                    Console.WriteLine($"boss používá ohnivý útok!");
                    break;
                case 3:
                    Console.WriteLine($"boss používá smrtící kouzlo!");
                    break;
                default:
                    base.Utoc();
                    break;
            }
        }

        public void PrepniBojovyRezim()
        {
            BojovyRezim = !BojovyRezim;
            Console.WriteLine($"Final boss {(BojovyRezim ? "aktivuje" : "deaktivuje")} bojový režim!");
        }

        public int VypocitejPoskozeni(int zakladniPoskozeni)
        {
            if (zakladniPoskozeni < 0)
                throw new ArgumentException("Základní poškození nemůže být záporné.", nameof(zakladniPoskozeni));

            int poskozeni = zakladniPoskozeni * Faze;


            if (BojovyRezim)
            {
                poskozeni *= 2; // Přidání bonusového poškození v bojovém režimu
            }
            return poskozeni;
        }

        public int VypocitejObranu(int poskozeni)
        {
            if (poskozeni < 0)
                throw new ArgumentException("Poškození nemůže být záporné.", nameof(poskozeni));

            return poskozeni * (100 - Pancir) / 100;

        }

        public void VypisInformace()
        {
            Console.WriteLine($"Final Boss: {Jmeno}, Zivoty: {Zivoty}, Faze: {Faze}, Pancir: {Pancir}, Pocet Utoku: {PocetUtoku}, Bojovy Rezim: {BojovyRezim}");
        }

    }
}