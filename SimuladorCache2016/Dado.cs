namespace SimuladorCache2016
{
    public class Dado
    {
        public Dado(int tag, int idBloco)
        {
            this.tag = tag;
            this.idBloco = idBloco;
        }

        public int tag { get; private set; }

        public int valor { get; set; }

        public int idBloco { get; private set; }
    }
}