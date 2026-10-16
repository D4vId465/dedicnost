namespace Dedicnost
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            // testovací prostředí
            Bojovnik Barbar = new Bojovnik("Aragorn", "Meč");
            Kouzelnik Mage = new Kouzelnik("Gandalf", 9, 100);
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