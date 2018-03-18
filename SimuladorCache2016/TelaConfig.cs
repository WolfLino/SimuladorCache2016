using System;
using System.Windows.Forms;

namespace SimuladorCache2016
{
    public partial class TelaConfig : Form
    {
        public TelaConfig(Memoria memoria, Cache cache)
        {
            InitializeComponent();

            this.memoria = memoria;
            this.cache = cache;
            this.gerador = new Gerador();
        }

        /// <summary>
        /// Obtem a memória usada na simulação.
        /// </summary>
        public Memoria memoria { get; private set; }
        /// <summary>
        /// Obtem a cache usada na simulação.
        /// </summary>
        public Cache cache { get; private set; }

        private Gerador gerador;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Cria a memória com todos os dados gerados
            memoria = gerador.GerarDados(new Memoria(Convert.ToInt32(numMemoria.Value), Convert.ToInt32(numBloco.Value)),
                                         Convert.ToInt32(numMin.Value),
                                         Convert.ToInt32(numMax.Value));

            // Cria uma cache vazia
            cache = new Cache(Convert.ToInt32(numCache.Value));

            this.Close();
        }

        private void numBloco_ValueChanged(object sender, EventArgs e)
        {
            // Define o valor mínimo da memória toda vez que altera o tamanho do bloco
            numMemoria.Minimum = numBloco.Value * numCache.Value;

            validaConfig();
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {
            // Define o valor mínimo da memória
            numMemoria.Minimum = numBloco.Value * numCache.Value;

            // Limpa a nota
            lblNotaMem.Text = string.Empty;
        }

        private void numCache_ValueChanged(object sender, EventArgs e)
        {
            // Define o valor mínimo da memória
            numMemoria.Minimum = numBloco.Value * numCache.Value;

            validaConfig();
        }

        private void numMemoria_ValueChanged(object sender, EventArgs e)
        {
            validaConfig();
        }

        /// <summary>
        /// Faz a validação da tela.
        /// </summary>
        private void validaConfig()
        {
            if (numMemoria.Value < numBloco.Value * numCache.Value ||
                numBloco.Value < 1 ||
                numCache.Value < 2 ||
                cmbMetodo.Text == string.Empty)
                btnConfirmar.Enabled = false;
            else
                btnConfirmar.Enabled = true;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            numMax.Minimum = numMin.Value;
        }

        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            numMin.Maximum = numMax.Value;
        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validaConfig();
        }
    }

    /// <summary>
    /// Representa um gerador de dados para a memória.
    /// </summary>
    class Gerador
    {

        public Gerador() { }

        public Gerador(Memoria memoria)
        {
            this.memoria = memoria;
        }

        public Memoria memoria { get; private set; }

        /// <summary>
        /// Gera valores aleatórios para os dados da memória.
        /// </summary>
        /// <param name="memoria">Memória usada para gerar os dados.</param>
        /// <param name="min">Valor mínimo dos dados.</param>
        /// <param name="max">Valor máximo dos dados.</param>
        /// <returns></returns>
        public Memoria GerarDados(Memoria memoria, int min, int max)
        {
            Random valor = new Random();

            foreach (Dado dado in memoria.dados)
            {
                dado.valor = valor.Next(min, max);
            }

            return memoria;
        }

        /// <summary>
        /// Gera valores aleatórios para os dados da memória.
        /// </summary>
        /// <param name="min">Valor mínimo dos dados.</param>
        /// <param name="max">Valor máximo dos dados.</param>
        /// <returns></returns>
        public Memoria GerarDados(int min, int max)
        {
            return GerarDados(this.memoria, min, max);
        }
    }
}
