namespace velocidadeInternet {
    partial class frmMenu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblVelocidadeConexao = new System.Windows.Forms.Label();
            this.txtQuantidadeDados1 = new System.Windows.Forms.TextBox();
            this.cbxMedidaDados1 = new System.Windows.Forms.ComboBox();
            this.lblTamanhoArquivo = new System.Windows.Forms.Label();
            this.txtQuantidadeDados2 = new System.Windows.Forms.TextBox();
            this.cbxMedidaDados2 = new System.Windows.Forms.ComboBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.stbBarraStatus = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVelocidadeConexao
            // 
            this.lblVelocidadeConexao.AutoSize = true;
            this.lblVelocidadeConexao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidadeConexao.Location = new System.Drawing.Point(75, 94);
            this.lblVelocidadeConexao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVelocidadeConexao.Name = "lblVelocidadeConexao";
            this.lblVelocidadeConexao.Size = new System.Drawing.Size(306, 32);
            this.lblVelocidadeConexao.TabIndex = 0;
            this.lblVelocidadeConexao.Text = "Velocidade de Conexão";
            // 
            // txtQuantidadeDados1
            // 
            this.txtQuantidadeDados1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDados1.Location = new System.Drawing.Point(393, 89);
            this.txtQuantidadeDados1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidadeDados1.Name = "txtQuantidadeDados1";
            this.txtQuantidadeDados1.Size = new System.Drawing.Size(318, 39);
            this.txtQuantidadeDados1.TabIndex = 1;
            // 
            // cbxMedidaDados1
            // 
            this.cbxMedidaDados1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedidaDados1.FormattingEnabled = true;
            this.cbxMedidaDados1.Items.AddRange(new object[] {
            "Kbps",
            "KBps",
            "Mbps",
            "MBps",
            "Gbps",
            "GBps"});
            this.cbxMedidaDados1.Location = new System.Drawing.Point(723, 89);
            this.cbxMedidaDados1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMedidaDados1.Name = "cbxMedidaDados1";
            this.cbxMedidaDados1.Size = new System.Drawing.Size(180, 40);
            this.cbxMedidaDados1.TabIndex = 2;
            this.cbxMedidaDados1.Text = "Selecione";
            // 
            // lblTamanhoArquivo
            // 
            this.lblTamanhoArquivo.AutoSize = true;
            this.lblTamanhoArquivo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoArquivo.Location = new System.Drawing.Point(112, 155);
            this.lblTamanhoArquivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanhoArquivo.Name = "lblTamanhoArquivo";
            this.lblTamanhoArquivo.Size = new System.Drawing.Size(267, 32);
            this.lblTamanhoArquivo.TabIndex = 3;
            this.lblTamanhoArquivo.Text = "Tamanho do Arquivo";
            // 
            // txtQuantidadeDados2
            // 
            this.txtQuantidadeDados2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeDados2.Location = new System.Drawing.Point(393, 150);
            this.txtQuantidadeDados2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantidadeDados2.Name = "txtQuantidadeDados2";
            this.txtQuantidadeDados2.Size = new System.Drawing.Size(318, 39);
            this.txtQuantidadeDados2.TabIndex = 4;
            // 
            // cbxMedidaDados2
            // 
            this.cbxMedidaDados2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedidaDados2.FormattingEnabled = true;
            this.cbxMedidaDados2.Items.AddRange(new object[] {
            "Kb",
            "KB",
            "Mb",
            "MB",
            "Gb",
            "GB"});
            this.cbxMedidaDados2.Location = new System.Drawing.Point(723, 150);
            this.cbxMedidaDados2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMedidaDados2.Name = "cbxMedidaDados2";
            this.cbxMedidaDados2.Size = new System.Drawing.Size(180, 40);
            this.cbxMedidaDados2.TabIndex = 5;
            this.cbxMedidaDados2.Text = "Selecione";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(262, 217);
            this.lblTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(97, 32);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(393, 211);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.ReadOnly = true;
            this.txtTempo.Size = new System.Drawing.Size(318, 39);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(723, 208);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(182, 47);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(393, 264);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(512, 52);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(393, 325);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(512, 52);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // stbBarraStatus
            // 
            this.stbBarraStatus.Location = new System.Drawing.Point(0, 439);
            this.stbBarraStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stbBarraStatus.Name = "stbBarraStatus";
            this.stbBarraStatus.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbBarraStatus.ShowPanels = true;
            this.stbBarraStatus.Size = new System.Drawing.Size(1059, 34);
            this.stbBarraStatus.TabIndex = 11;
            this.stbBarraStatus.Text = "statusBar";
            this.stbBarraStatus.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.stbBarraStatus_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 115;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "Jvps";
            this.statusBarPanel2.Width = 400;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 473);
            this.Controls.Add(this.stbBarraStatus);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.cbxMedidaDados2);
            this.Controls.Add(this.txtQuantidadeDados2);
            this.Controls.Add(this.lblTamanhoArquivo);
            this.Controls.Add(this.cbxMedidaDados1);
            this.Controls.Add(this.txtQuantidadeDados1);
            this.Controls.Add(this.lblVelocidadeConexao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Medidor de tempo de dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVelocidadeConexao;
        private System.Windows.Forms.TextBox txtQuantidadeDados1;
        private System.Windows.Forms.ComboBox cbxMedidaDados1;
        private System.Windows.Forms.Label lblTamanhoArquivo;
        private System.Windows.Forms.TextBox txtQuantidadeDados2;
        private System.Windows.Forms.ComboBox cbxMedidaDados2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.StatusBar stbBarraStatus;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
    }
}

