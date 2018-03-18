using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorCache2016
{
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
        }

        private Memoria memoria;
        private Cache cache;

        private void btnCriarSimulacao_Click(object sender, EventArgs e)
        {
            TelaConfig config = new TelaConfig(memoria, cache);
            config.ShowDialog();

            memoria = config.memoria;
            cache = config.cache;

            IniciaSimulacao();
        }

        private void IniciaSimulacao()
        {
            dgvMemoria.Columns.Clear();
            dgvMemoria.Columns.Add("clTag", "Tag");
        }
    }
}
