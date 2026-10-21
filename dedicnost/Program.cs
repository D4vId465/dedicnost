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

            Postava Terminator = new Boss(3, "Terminator", 1000);
            Bojovnik Barbar = new Bojovnik(1, "Aragorn", "Meč");
            Kouzelnik Mage = new Kouzelnik(2, "Gandalf", 9, 100);


            Terminator.PredstavSe();
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