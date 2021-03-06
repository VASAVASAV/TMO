﻿using System;
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
            RefreshView();
        }

        public void CheckData(bool Type, double alfa)
        {
            if (!MyModel.CheckData())
            {
                View.ShowMessage("Nothing to do");
                return;
            }
            int NumbOfClasses = ToolsForWork.CompNumOfClasses(MyModel.GetData().Count);
            double result =  MyModel.CheckDataDist(Type, alfa);
            if (Type)
            {
                double quan = Quantile.HirsQuan(1 - alfa, NumbOfClasses - 1);
                if (result <= quan)
                {
                    View.ShowMessage("За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(alfa, 5) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------");
                }
                else
                {
                    View.ShowMessage("За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(alfa, 5) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------");
                }
            }
            else
            {
                if (result >= alfa)//quan)
                {
                    View.ShowMessage("За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(alfa, 5) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" );
                }
                else
                {
                    View.ShowMessage("За уточненим критерієм згоди Колмогорова гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(alfa, 5) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" );
                }
            }
        }

        public List<double> GetDataFromModel()
        {
            return MyModel.GetData();
        }

        public void RefreshView()
        {
            List<double> Data = MyModel.GetData();
            View.PaintDistFuncs(Data);
            View.DrawTable(Data);
        }

        public void RemoveVal(double Value)
        {
            MyModel.DeleteVal(Value);
            RefreshView();
        }
    }
}
