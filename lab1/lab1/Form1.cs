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
            int i, j;
            for (i = 0; i < Numb; i++)
            {
                dataGridView3.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView3.Rows.Add();
                dataGridView1.Rows.Add();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numb = dataGridView1.Rows.Count;
            if (Numb < 1)
            {
                return;
            }
            int i, j;
            double[,] Matrix = new double[Numb, Numb];
            double[,] Vector = new double[1, Numb];
            int steps;
            try
            {
                steps = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                return;
            }
            try
            {
                for (i = 0; i < Numb; i++)
                {
                    Vector[0, i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    for (j = 0; j < Numb; j++)
                    {
                        Matrix[i, j] = Convert.ToDouble(dataGridView3.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch
            {
                return;
            }
            int eps;
            try
            {
                eps = Convert.ToInt32(textBox3.Text);
                if (eps < 1)
                    throw new Exception();
            }
            catch
            {
                eps = 5;
            }
            dataGridView2.Rows.Clear();
            Vector = Matrixes.Multiply(Vector, Matrix);
            for (j = 0; j < steps; j++)
            {
                Vector = Matrixes.Multiply(Vector, Matrix);
            }
            for (i = 0; i < Numb; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = Math.Round(Vector[0, i],eps);
            }
        }
    }
}
