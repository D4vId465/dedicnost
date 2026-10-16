namespace Dedicnost
{
    public class Postava
    {
        private string jmeno;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public Postava(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public virtual void Utoc()
        {
            Console.WriteLine(jmeno + " útočí!");
        }
        public void PredstavSe()
        {
            Console.WriteLine("Jmenuji se " + jmeno + ".");
        }
    }
}