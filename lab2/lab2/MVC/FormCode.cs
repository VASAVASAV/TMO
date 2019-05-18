using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    partial class MainForm
    {
        public static Controller MyCont;


        public MainForm()
        {
            InitializeComponent();
        }

        private void ВийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ВідкритичасовийРядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath.ToString(),
                Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                MyCont.ReadFile(OpeningDialog, true);
            }
        }

        private void ВідкритирозподілΤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath.ToString(),
                Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                MyCont.ReadFile(OpeningDialog,false);
            }
            //this.ProgressBar.Value = 1;

        }

        public void ShowMessage(string Message)
        {
            textBox1.Text += Message + Environment.NewLine;
        }

        public void PaintCumDistFunc()
        {

        }

        public void PaintDensDistFunc()
        {

        }
    }
    
}
