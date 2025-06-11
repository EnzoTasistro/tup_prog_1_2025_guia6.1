using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int num;
        int contador;
        int acum;
        private void btnAcmular_Click(object sender, EventArgs e)
        {
            contador++;

            num = Convert.ToInt32(TbAcum.Text);

            acum = acum + num;

            TbAcum.Clear();

           TbValorAcum.Text = acum.ToString();

        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {

            int promedio = acum/contador;

            TbPromedio.Text = promedio.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
