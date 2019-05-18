using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Controller
    {
        MainForm View;
        Model MyModel;

        public Controller(MainForm InpForm, Model InpModel)
        {
            View = InpForm;
            MyModel = InpModel;
            MainForm.MyCont = this;
            Model.MyCont = this;
        }

        public void ReadFile(System.Windows.Forms.OpenFileDialog file, bool NeedsComputing)
        {
            //this.ProgressBar.Step = 100;
            //this.ProgressBar.PerformStep();
            //this.ProgressBar.Value = 50;
            List<double> temp = new List<double>();
            string[] FileLikeStrings = File.ReadAllLines(file.FileName);
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
                        valuesInLine[j] = valuesInLine[j].Replace(".", ",");
                        x = Convert.ToDouble(valuesInLine[j]);
                    }
                    catch
                    {
                        View.ShowMessage("Theres mistake in string #" + i);
                        continue;
                    }
                    temp.Add(x);
                }
            }
            temp.Sort();
            if (NeedsComputing == false)
            {
                MyModel.SetData(temp);
            }
            else
            {
                List<double> intervals = new List<double>();
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    intervals.Add(temp[i + 1] - temp[i]);
                }
                MyModel.SetData(intervals);
            }
        }

    }
}
