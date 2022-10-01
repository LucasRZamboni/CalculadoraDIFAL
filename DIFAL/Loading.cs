using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DIFAL
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();


            backgroundWorker1.RunWorkerAsync();

        }

        /*

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 550)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            if (progressBar1.Value > 500)
            {
                timer1.Stop();

                var form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
        }

        */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 1 ; i <= 101; i++)
            {
                // Wait 100 milliseconds.
                Thread.Sleep(45);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            label2.Text = e.ProgressPercentage.ToString()+"%";
            if(label2.Text == "100%")
            {
                
                label3.Text = "Pronto!";
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO: do something with final calculation.
            

            var form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

    }
}
