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
        Controller MyCont;

        public MainForm()
        {
            InitializeComponent();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void відкритирозподілΤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog();

            OpeningDialog.InitialDirectory = Application.StartupPath.ToString();
            OpeningDialog.Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat";
            OpeningDialog.FilterIndex = 1;
            OpeningDialog.RestoreDirectory = true;

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                Controller.ReadFile(OpeningDialog.FileName, false);
                return;
                //this.ProgressBar.Step = 100;
                //this.ProgressBar.PerformStep();
                //this.ProgressBar.Value = 50;
                List<double> temp = new List<double>();
                string[] FileLikeStrings = File.ReadAllLines(OpeningDialog.FileName);
                char[] separators = new char[] { ' ', '\t', '\n' };
                for (int i = 0; i < FileLikeStrings.Length; i++)
                {
                    ToolsForWork.RemoveComments(ref FileLikeStrings[i]);
                    string[] valuesInLine = FileLikeStrings[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < valuesInLine.Length; j++)
                    {
                        double x;
                        try
                        {
                            x = Convert.ToDouble(valuesInLine[j]);
                        }
                        catch
                        {
                            try
                            {
                                valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                                x = Convert.ToDouble(valuesInLine[j]);
                            }
                            catch
                            {
                                if (LogCheckBox.Checked == true)
                                    LogOutputTextBox.Text += "Theres mistake in string #" + i + Environment.NewLine;
                                continue;
                            }
                        }
                        temp.Add(x);
                    }
                }

                TechnicalWorkOneDim(OpeningDialog.FileName, temp);
            }
            //this.ProgressBar.Value = 1;

        }
    }
    }
}
