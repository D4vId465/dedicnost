namespace Dedicnost
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            // testovací prostředí
            Bojovnik[] legie = new Bojovnik[1000];

            legie[0] = new Bojovnik(1, "Aragorn", "Meč");
            legie[1] = new Bojovnik(2, "Legolas", "Meč");

            // Postava postava = new Postava(22, "Test", 1);
            List<Postava> postavy = new List<Postava>
            {
                new Bojovnik(1, "Aragorn", "Meč"),
                new Kouzelnik(2, "Gandalf", 9, 100),
                new Boss(3, "Terminator", 1000)
            };
            foreach (Postava postava in postavy)
            {
                postava.PredstavSe();
                postava.Utoc();
            }
            Boss Terminator = new Boss(3, "Terminator", 1000);
            Bojovnik Barbar = new Bojovnik(1, "Aragorn", "Meč");
            Kouzelnik Mage = new Kouzelnik(2, "Gandalf", 9, 100);
            FinalBoss GaroshHellscream = new FinalBoss(4, "Garosh Hellscream", 10000, 11);

            GaroshHellscream.VypisInformace();
            GaroshHellscream.PrepniBojovyRezim();
            GaroshHellscream.Utoc();
            GaroshHellscream.VypisInformace();

            Console.WriteLine($"Poškození: {GaroshHellscream.VypocitejPoskozeni(100)}");


            Terminator.Utoc();
            Terminator.Zastras();
            Barbar.PredstavSe();
            Barbar.Utoc();
            Barbar.ZvedniStit();

            Mage.PredstavSe();
            Mage.Utoc();
            
            
            Console.WriteLine(Barbar.Jmeno);

            Barbar.Jmeno = "Boromir";

            Console.WriteLine(Barbar.Jmeno);

            Console.WriteLine(Mage.Jmeno);

            Mage.Meditace();
        }
    }
}