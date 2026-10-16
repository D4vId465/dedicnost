namespace Dedicnost
{
    class Bojovnik : Postava
    {
        private string zbran;
        public Bojovnik(string jmeno, string zbran) : base(jmeno)
        {
            this.zbran = zbran;
        }
        public void ZvedniStit()
        {
            Console.WriteLine("Bojovník zvedá štít a brání se...");
        }
        public override void Utoc()
        {
            Console.WriteLine("útočím s " + zbran + "!");
        }
    }
}