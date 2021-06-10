namespace CalculadoraFretesTAC
{
    partial class frmCalculadoraFrete
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadoraFrete));
            this.lblValorCarga = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.txbKm = new System.Windows.Forms.TextBox();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskTxbValorCarga = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoFrete = new System.Windows.Forms.Label();
            this.cmbTipoFrete = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorCarga
            // 
            this.lblValorCarga.AutoSize = true;
            this.lblValorCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCarga.Location = new System.Drawing.Point(2, 18);
            this.lblValorCarga.Name = "lblValorCarga";
            this.lblValorCarga.Size = new System.Drawing.Size(119, 20);
            this.lblValorCarga.TabIndex = 0;
            this.lblValorCarga.Text = "Valor da Carga:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(36, 125);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(36, 20);
            this.lblKm.TabIndex = 1;
            this.lblKm.Text = "Km:";
            // 
            // txbKm
            // 
            this.txbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKm.Location = new System.Drawing.Point(127, 122);
            this.txbKm.MaxLength = 500;
            this.txbKm.Name = "txbKm";
            this.txbKm.Size = new System.Drawing.Size(144, 26);
            this.txbKm.TabIndex = 3;
            this.txbKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKm_KeyPress);
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrete.Location = new System.Drawing.Point(16, 193);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(114, 20);
            this.lblFrete.TabIndex = 4;
            this.lblFrete.Text = "Valor do Frete:";
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.AutoSize = true;
            this.lblValorFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFrete.ForeColor = System.Drawing.Color.Green;
            this.lblValorFrete.Location = new System.Drawing.Point(137, 192);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(0, 24);
            this.lblValorFrete.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(304, 18);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(304, 68);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 36);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoFrete);
            this.groupBox1.Controls.Add(this.lblTipoFrete);
            this.groupBox1.Controls.Add(this.mskTxbValorCarga);
            this.groupBox1.Controls.Add(this.txbKm);
            this.groupBox1.Controls.Add(this.lblKm);
            this.groupBox1.Controls.Add(this.lblValorCarga);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // mskTxbValorCarga
            // 
            this.mskTxbValorCarga.AllowDrop = true;
            this.mskTxbValorCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxbValorCarga.HidePromptOnLeave = true;
            this.mskTxbValorCarga.Location = new System.Drawing.Point(127, 17);
            this.mskTxbValorCarga.Name = "mskTxbValorCarga";
            this.mskTxbValorCarga.Size = new System.Drawing.Size(144, 26);
            this.mskTxbValorCarga.TabIndex = 1;
            // 
            // lblTipoFrete
            // 
            this.lblTipoFrete.AutoSize = true;
            this.lblTipoFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFrete.Location = new System.Drawing.Point(6, 73);
            this.lblTipoFrete.Name = "lblTipoFrete";
            this.lblTipoFrete.Size = new System.Drawing.Size(107, 20);
            this.lblTipoFrete.TabIndex = 3;
            this.lblTipoFrete.Text = "Tipo de Frete:";
            // 
            // cmbTipoFrete
            // 
            this.cmbTipoFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFrete.FormattingEnabled = true;
            this.cmbTipoFrete.Items.AddRange(new object[] {
            "TAC",
            "ETC"});
            this.cmbTipoFrete.Location = new System.Drawing.Point(127, 70);
            this.cmbTipoFrete.Name = "cmbTipoFrete";
            this.cmbTipoFrete.Size = new System.Drawing.Size(144, 28);
            this.cmbTipoFrete.TabIndex = 2;
            // 
            // frmCalculadoraFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorFrete);
            this.Controls.Add(this.lblFrete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadoraFrete";
            this.Text = "Calculadora de Fretes DF ";
            this.Activated += new System.EventHandler(this.FrmCalculadoraFrete_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalcTAC_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadoraFrete_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorCarga;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txbKm;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblValorFrete;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskTxbValorCarga;
        private System.Windows.Forms.ComboBox cmbTipoFrete;
        private System.Windows.Forms.Label lblTipoFrete;
    }
}

