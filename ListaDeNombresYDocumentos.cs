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

        Fdatos ventanaDatos = new Fdatos();
        int contador = 0;
        string[] Nombre = new string[30];
        int[] DNIS = new int[30];
        
       private void btnAgregar_Click(object sender, EventArgs e) //DialogResult
        {

             //creo un objeto con new Fdatos de tipo Fdatos.



                  if(ventanaDatos.ShowDialog()== DialogResult.OK) //la ventana quedará abierta hasta que el usuario de una respuesta.
                  {



                    Nombre[contador] = ventanaDatos.TbNombre.Text; 
                    LbAlumno.Items.Add($"{ventanaDatos.TbNombre.Text}"); //acceder a Text box nombre que está dentro de ventanaDatos.

                    DNIS[contador] = Convert.ToInt32(ventanaDatos.TbDNI.Text); //guarda el dni ingresado en el lugar del vector.
                    
                    contador++;
                  }
                  else
                  {

                   MessageBox.Show("Cancelado por el usuario");  //Si el usuario apreta cancelar, aparece este mensaje.

                   ventanaDatos.Dispose();  //Sirve para limpiar los recursos y liberar espacio de la memoria. (OBLIGATORIO)

                  }

                    ventanaDatos.TbNombre.Clear();   //limpiar los datos en pantalla
                    ventanaDatos.TbDNI.Clear();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            int indice = LbAlumno.SelectedIndex;  //devuelve un numero según el elemento seleccionado, sive para poder buscar el nombre y dni en el vector.
            if (indice > -1 && indice < contador)
            {

                ventanaDatos.TbNombre.Text = Nombre[indice];
                ventanaDatos.TbDNI.Text = DNIS[indice].ToString("00,000,000");
                ventanaDatos.ShowDialog();  //Muestra la ventana y da la posibilidad de usar el DialogResult. (IMPORTANTE)

            }
            else
            {

                MessageBox.Show("Debe seleccionar una persona");

            }


        }

        private string[] Ordenar()
        {
            string[] lista = new string[contador]; //vector guardar los datos en una lista
            int[] auxDni = new int [contador];
            string[] auxNombre = new string[contador];

            for (int i = 0; i < contador; i++)
            {

                auxDni[i] = DNIS[i];
                auxNombre[i] = Nombre[i];

            }
            int aux;
            string auxN;
            for (int i = 0; i < auxDni.Length - 1; i++)
                for (int j = i + 1; j < auxDni.Length; j++)
                    if (auxDni[i] < auxDni[j])
                    {

                        aux = auxDni[i];
                        auxDni[i] = auxDni[j];
                        auxDni[j] = aux;

                        auxN = auxNombre[i];
                        auxNombre[i] = auxNombre[j];
                        auxNombre[j] = auxN;
                    }

            for (int i = 0; i < lista.Length; i++)
            {

                lista[i] = auxDni[i].ToString($"00,000,000")+ " " + auxNombre[i]; 

            }

            return lista;

        }

        private void btnOrdenado_Click(object sender, EventArgs e)
        {
            string[] mostrar = Ordenar();

            FOrdenada Ordenada = new FOrdenada();

            foreach (string linea in mostrar)
            {
             
                Ordenada.LbOrdenada.Items.Add(linea);

            }

                Ordenada.ShowDialog();
                Ordenada.Dispose();

        }
    }
}
