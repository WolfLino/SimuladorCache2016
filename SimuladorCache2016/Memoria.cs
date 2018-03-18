using System.Collections.Generic;

namespace SimuladorCache2016
{
    public class Memoria
    {
        public Memoria(int qntDados, int tamanhoBloco)
        {
            dados = new List<Dado>();
            this.tamanhoBloco = tamanhoBloco;

            int qntTotalDados = qntDados + (qntDados % tamanhoBloco);
            
            for (int i = 0; i < qntTotalDados; i++)
            {
                dados.Add(new Dado(i, i / tamanhoBloco));
            }
        }

        public List<Dado> dados { get; set; }

        public int tamanhoBloco { get; set; }
    }
}