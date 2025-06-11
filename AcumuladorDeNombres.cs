using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        int contador = 0;
        private void Listar_Click(object sender, EventArgs e)
        {


            string[] nombres = new string[10];          

            nombres[contador] = TbNombre.Text;



            TbNombre.Clear();

            TbNombres.Text += nombres[contador] + Environment.NewLine;

            contador++;
        }

    }



}
