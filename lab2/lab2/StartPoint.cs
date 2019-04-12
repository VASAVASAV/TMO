using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab2
{
    class StartPoint
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // ususal shit
            MainForm Program = new MainForm();
            Model MainModel = new Model();
            Controller MainControler = new Controller(Program, MainModel);
            Application.Run(Program); //creating and running our form is way to initialize all programm.
        }
    }
}
