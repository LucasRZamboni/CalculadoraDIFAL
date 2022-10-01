using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIFAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string data;

           data = DateTime.Now.ToString("dd/MM/yyyy");

            label3.Text = "Data: " + data;
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            
            tb_resultado.Text = Global.difal.ToString("C2");
           // tb_fcp.Text = Global.valor_fcp.ToString("C2");
          // tb_pre_difal.Text = Global.pre_difal.ToString("C2");

            /*
            textBox1.Text = Global.icms_interestadual.ToString("C2");
            textBox2.Text = Global.base_calculo1.ToString("C2");
            textBox3.Text = Global.base_calculo2.ToString("C2");
            textBox4.Text = Global.icms_interno.ToString("C2");
            */
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_rj_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);
            
            calculos.Cálculo6rj();
        }

        private void bt_pr_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo6();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_resultado.Text = "0";
            
          //  tb_fcp.Text = "0";

          //  tb_pre_difal.Text = "0";

            tb_valoricms.Text = "0";

        }

        private void bt_ac_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo10();
        }

        private void bt_al_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo5();
        }

        private void bt_am_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_ap_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_ba_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_es_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo10();
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo10();
        }

        private void bt_ma_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_ro_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_rr_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo10();
        }

        private void bt_sc_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo5();
        }

        private void bt_se_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo11();
        }

        private void bt_pi_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo10pi();
        }

        private void bt_mg_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculomg();
        }

        private void bt_df_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_18();
        }

        private void bt_mt_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_17();
        }

        private void bt_ms_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_17();
        }

        private void bt_pa_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_17();
        }

        private void bt_pb_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_18();
        }

        private void bt_pe_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_18();
        }

        private void bt_rn_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_18();
        }

        private void bt_rs_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo12_18();
        }

        private void bt_to_Click(object sender, EventArgs e)
        {
            Global.valor_icms = double.Parse(tb_valoricms.Text);

            calculos.Cálculo7_18();
        }

        private void bt_dicas_Click(object sender, EventArgs e)
        {

            var dicas = new Dicas();
            dicas.Show();
                            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var barcode = new Barcode();
            barcode.Show();
        }

        private bool mover;
        private int cX, cY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Left += e.X - (cX - panel1.Left);
                this.Top += e.Y - (cY - panel1.Top);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                cX = e.X;
                cY = e.Y;
                mover = true;
            }
        }

    }
}
