using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador = 0;
        double acumulador = 0;
        double valor = 0;
        double[] valores = new double[20];  //El vector se define fuera del botón
        double promedio = 0;  
        
        private void btnRegistrar_Click(object sender, EventArgs e)  //Guarda el valor ingresado, lo acumula  y lo cuenta
        {
            contador = contador + 1;   //cantidad de numeros ingresada
            valor = Convert.ToDouble(TbValor.Text);  //se toma el valor de la casilla de la Text Box Valor
            valores[contador] = valor;  //Se da el valor a la casilla del vector, según la cantidad de numeros ingresada

            acumulador = acumulador + valor;  //Se acumula el valor para luego hacer el promedio

            TbValor.Clear();  //limpia la pantalla

        }

        private void btnPromedio_Click(object sender, EventArgs e)   //Boton para calcular el promedio
        {

            promedio = acumulador / contador;   //Calcula promedio

            TbPromedio.Text = promedio.ToString(); //Muestra el promedio calculado en la Text Box Promedio

        }

        private void btnValor2_Click(object sender, EventArgs e) //muestra el segundo valor ingresado
        {

            TbValor2.Text = valores[1].ToString();  //Muestra el valor el la posicion 2 de el vector

        }
    }
}
