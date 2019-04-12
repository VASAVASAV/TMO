using System;
using System.Collections.Generic;
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
        }

        public void ReadFile(string NameOfFile, bool NeedsComputing)
        {

        }
    }
}
