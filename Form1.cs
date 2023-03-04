using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velocidadeInternet {
    public partial class frmMenu : Form {
        public double qtdDados1, qtdDados2, vlr1, vlr2;
        
        private void txtTempo_TextChanged(object sender, EventArgs e) { }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtQuantidadeDados1.Text = "";
            txtQuantidadeDados2.Text = "";
            txtTempo.Text = "";
            cbxMedidaDados1.Text = "Selecione";
            cbxMedidaDados2.Text = "Selecione";
        }

        private void btnSair_Click(object sender, EventArgs e) { Application.Exit(); }

        private void timer1_Tick(object sender, EventArgs e) {
            stbBarraStatus.Panels[0].Text = DateTime.Now.ToString("G");
        }

        private void stbBarraStatus_PanelClick(object sender, StatusBarPanelClickEventArgs e) { }

        private void btnCalcular_Click(object sender, EventArgs e) {
            qtdDados1 = Convert.ToDouble(txtQuantidadeDados1.Text);
            qtdDados2 = Convert.ToDouble(txtQuantidadeDados2.Text);

            long Kbps, KBps, Mbps, MBps, Gbps, GBps, Kb, KB, Mb, MB, Gb, GB;
            Kbps = Kb = 1024;
            KBps = KB = 8192;
            Mbps = Mb = 1_048_576;
            MBps = MB = 8_388_608;
            Gbps = Gb = 1_073_741_824;
            GBps = GB = 8_589_934_592;

            switch (cbxMedidaDados1.Text)
            {
                case "Kbps":
                    vlr1 = (qtdDados1 * Kbps);
                    break;
                case "KBps":
                    vlr1 = (qtdDados1 * KBps);
                    break;
                case "Mbps":
                    vlr1 = (qtdDados1 * Mbps);
                    break;
                case "MBps":
                    vlr1 = (qtdDados1 * MBps);
                    break;
                case "Gbps":
                    vlr1 = (qtdDados1 * Gbps);
                    break;
                case "GBps":
                    vlr1 = (qtdDados1 * GBps);
                    break;
            }

            switch (cbxMedidaDados2.Text)
            {
                case "Kb":
                    vlr2 = (qtdDados2 * Kb);
                    break;
                case "KB":
                    vlr2 = (qtdDados2 * KB);
                    break;
                case "Mb":
                    vlr2 = (qtdDados2 * Mb);
                    break;
                case "MB":
                    vlr2 = (qtdDados2 * MB);
                    break;
                case "Gb":
                    vlr2 = (qtdDados2 * Gb);
                    break;
                case "GB":
                    vlr2 = (qtdDados2 * GB);
                    break;
            }

            double segundos = (vlr2 / vlr1);
            TimeSpan tempo = TimeSpan.FromSeconds(segundos);

            if (segundos < 1) txtTempo.Text = "Menos de um segundo!";
            else txtTempo.Text = tempo.ToString(@"dd\.hh\:mm\:ss");
        }

        public frmMenu() {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
