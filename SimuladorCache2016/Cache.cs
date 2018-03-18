using System.Collections.Generic;

namespace SimuladorCache2016
{
    public class Cache
    {
        /// <summary>
        /// Cria uma memória cache com uma quantidade de blocos.
        /// </summary>
        /// <param name="tamanhoCache">Quantidade total de blocos que a cache suporta.</param>
        public Cache(int tamanhoCache)
        {
            blocos = new List<Bloco>();

            for (int i = 0; i < tamanhoCache; i++)
            {
                blocos.Add(new Bloco());
            }
        }

        /// <summary>
        /// Blocos da cache.
        /// </summary>
        public List<Bloco> blocos { get; set; }
    }
}