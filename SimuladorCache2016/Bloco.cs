using System.Collections.Generic;

namespace SimuladorCache2016
{
    public class Bloco
    {
        public Bloco()
        {
            dados = new List<Dado>();
        }

        public Bloco(List<Dado> dados)
        {
            this.dados = dados;
        }

        public List<Dado> dados { get; set; }
    }
}