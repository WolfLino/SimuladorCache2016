namespace SimuladorCache2016
{
    partial class Simulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarSimulacao = new System.Windows.Forms.Button();
            this.dgvMemoria = new System.Windows.Forms.DataGridView();
            this.dgvCache = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCache)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarSimulacao
            // 
            this.btnCriarSimulacao.Location = new System.Drawing.Point(536, 12);
            this.btnCriarSimulacao.Name = "btnCriarSimulacao";
            this.btnCriarSimulacao.Size = new System.Drawing.Size(151, 56);
            this.btnCriarSimulacao.TabIndex = 0;
            this.btnCriarSimulacao.Text = "Criar Simulação";
            this.btnCriarSimulacao.UseVisualStyleBackColor = true;
            this.btnCriarSimulacao.Click += new System.EventHandler(this.btnCriarSimulacao_Click);
            // 
            // dgvMemoria
            // 
            this.dgvMemoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemoria.Location = new System.Drawing.Point(13, 13);
            this.dgvMemoria.Name = "dgvMemoria";
            this.dgvMemoria.Size = new System.Drawing.Size(144, 357);
            this.dgvMemoria.TabIndex = 1;
            // 
            // dgvCache
            // 
            this.dgvCache.BackgroundColor = System.Drawing.Color.White;
            this.dgvCache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCache.Location = new System.Drawing.Point(163, 13);
            this.dgvCache.Name = "dgvCache";
            this.dgvCache.Size = new System.Drawing.Size(367, 150);
            this.dgvCache.TabIndex = 2;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 382);
            this.Controls.Add(this.dgvCache);
            this.Controls.Add(this.dgvMemoria);
            this.Controls.Add(this.btnCriarSimulacao);
            this.Name = "Simulador";
            this.Text = "Simulador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCache)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarSimulacao;
        private System.Windows.Forms.DataGridView dgvMemoria;
        private System.Windows.Forms.DataGridView dgvCache;
    }
}