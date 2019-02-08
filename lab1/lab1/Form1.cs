using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            //dataGridView1.Columns.Clear();
            dataGridView3.Columns.Clear();
            int Numb;
            try
            {
                Numb = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                return;
            }
            int i,j;
            for (i = 0; i < Numb; i++)
            {
                dataGridView3.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView3.Rows.Add();
            }
        }
    }
}
