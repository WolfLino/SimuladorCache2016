namespace SimuladorCache2016
{
    partial class TelaConfig
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
            this.lblTamMem = new System.Windows.Forms.Label();
            this.numMemoria = new System.Windows.Forms.NumericUpDown();
            this.lblTamCache = new System.Windows.Forms.Label();
            this.numCache = new System.Windows.Forms.NumericUpDown();
            this.lblBloco = new System.Windows.Forms.Label();
            this.numBloco = new System.Windows.Forms.NumericUpDown();
            this.lblNotaMem = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.grpMemorias = new System.Windows.Forms.GroupBox();
            this.grpSubstituicao = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.lvlDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBloco)).BeginInit();
            this.grpMemorias.SuspendLayout();
            this.grpSubstituicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTamMem
            // 
            this.lblTamMem.AutoSize = true;
            this.lblTamMem.Location = new System.Drawing.Point(6, 49);
            this.lblTamMem.Name = "lblTamMem";
            this.lblTamMem.Size = new System.Drawing.Size(112, 13);
            this.lblTamMem.TabIndex = 0;
            this.lblTamMem.Text = "Tamanho da memória:";
            // 
            // numMemoria
            // 
            this.numMemoria.Location = new System.Drawing.Point(124, 47);
            this.numMemoria.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numMemoria.Name = "numMemoria";
            this.numMemoria.Size = new System.Drawing.Size(78, 20);
            this.numMemoria.TabIndex = 1;
            this.numMemoria.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMemoria.ValueChanged += new System.EventHandler(this.numMemoria_ValueChanged);
            // 
            // lblTamCache
            // 
            this.lblTamCache.AutoSize = true;
            this.lblTamCache.Location = new System.Drawing.Point(6, 23);
            this.lblTamCache.Name = "lblTamCache";
            this.lblTamCache.Size = new System.Drawing.Size(103, 13);
            this.lblTamCache.TabIndex = 2;
            this.lblTamCache.Text = "Tamanho da cache:";
            // 
            // numCache
            // 
            this.numCache.Location = new System.Drawing.Point(124, 21);
            this.numCache.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCache.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCache.Name = "numCache";
            this.numCache.Size = new System.Drawing.Size(47, 20);
            this.numCache.TabIndex = 3;
            this.numCache.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCache.ValueChanged += new System.EventHandler(this.numCache_ValueChanged);
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Location = new System.Drawing.Point(208, 23);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 13);
            this.lblBloco.TabIndex = 4;
            this.lblBloco.Text = "Bloco:";
            // 
            // numBloco
            // 
            this.numBloco.Location = new System.Drawing.Point(251, 21);
            this.numBloco.Name = "numBloco";
            this.numBloco.Size = new System.Drawing.Size(54, 20);
            this.numBloco.TabIndex = 5;
            this.numBloco.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBloco.ValueChanged += new System.EventHandler(this.numBloco_ValueChanged);
            // 
            // lblNotaMem
            // 
            this.lblNotaMem.AutoSize = true;
            this.lblNotaMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNotaMem.Location = new System.Drawing.Point(208, 49);
            this.lblNotaMem.Name = "lblNotaMem";
            this.lblNotaMem.Size = new System.Drawing.Size(37, 13);
            this.lblNotaMem.TabIndex = 6;
            this.lblNotaMem.Text = "NOTA";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(6, 29);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(46, 13);
            this.lblMetodo.TabIndex = 7;
            this.lblMetodo.Text = "Método:";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "LRU",
            "FIFO"});
            this.cmbMetodo.Location = new System.Drawing.Point(58, 26);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo.TabIndex = 8;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // grpMemorias
            // 
            this.grpMemorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMemorias.Controls.Add(this.lblTamCache);
            this.grpMemorias.Controls.Add(this.lblTamMem);
            this.grpMemorias.Controls.Add(this.numMemoria);
            this.grpMemorias.Controls.Add(this.lblNotaMem);
            this.grpMemorias.Controls.Add(this.numCache);
            this.grpMemorias.Controls.Add(this.numBloco);
            this.grpMemorias.Controls.Add(this.lblBloco);
            this.grpMemorias.Location = new System.Drawing.Point(12, 33);
            this.grpMemorias.Name = "grpMemorias";
            this.grpMemorias.Size = new System.Drawing.Size(332, 86);
            this.grpMemorias.TabIndex = 9;
            this.grpMemorias.TabStop = false;
            this.grpMemorias.Text = "Memórias";
            // 
            // grpSubstituicao
            // 
            this.grpSubstituicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSubstituicao.Controls.Add(this.lblMetodo);
            this.grpSubstituicao.Controls.Add(this.cmbMetodo);
            this.grpSubstituicao.Location = new System.Drawing.Point(12, 125);
            this.grpSubstituicao.Name = "grpSubstituicao";
            this.grpSubstituicao.Size = new System.Drawing.Size(332, 83);
            this.grpSubstituicao.TabIndex = 10;
            this.grpSubstituicao.TabStop = false;
            this.grpSubstituicao.Text = "Método de Substituição";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(269, 318);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(188, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numMax);
            this.groupBox1.Controls.Add(this.lblAte);
            this.groupBox1.Controls.Add(this.lvlDe);
            this.groupBox1.Controls.Add(this.numMin);
            this.groupBox1.Controls.Add(this.lblAlcance);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 83);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geração de Dados";
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(6, 29);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(96, 13);
            this.lblAlcance.TabIndex = 7;
            this.lblAlcance.Text = "Alcance do dados:";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(33, 45);
            this.numMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(93, 20);
            this.numMin.TabIndex = 8;
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // lvlDe
            // 
            this.lvlDe.AutoSize = true;
            this.lvlDe.Location = new System.Drawing.Point(6, 47);
            this.lvlDe.Name = "lvlDe";
            this.lvlDe.Size = new System.Drawing.Size(21, 13);
            this.lvlDe.TabIndex = 9;
            this.lvlDe.Text = "De";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(132, 47);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(23, 13);
            this.lblAte.TabIndex = 10;
            this.lblAte.Text = "Até";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(161, 45);
            this.numMax.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(93, 20);
            this.numMax.TabIndex = 11;
            this.numMax.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // TelaConfig
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(356, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpSubstituicao);
            this.Controls.Add(this.grpMemorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Cache";
            this.Load += new System.EventHandler(this.TelaConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBloco)).EndInit();
            this.grpMemorias.ResumeLayout(false);
            this.grpMemorias.PerformLayout();
            this.grpSubstituicao.ResumeLayout(false);
            this.grpSubstituicao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTamMem;
        private System.Windows.Forms.NumericUpDown numMemoria;
        private System.Windows.Forms.Label lblTamCache;
        private System.Windows.Forms.NumericUpDown numCache;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.NumericUpDown numBloco;
        private System.Windows.Forms.Label lblNotaMem;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.GroupBox grpMemorias;
        private System.Windows.Forms.GroupBox grpSubstituicao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lvlDe;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label lblAlcance;
    }
}