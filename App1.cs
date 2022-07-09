using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class App1 : Form
    {
        public App1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String digitosIngresados = textBox1.Text;
            int contadorPares = 0;
            int contadorImPares = 0;
            char[] array1=new char[digitosIngresados.Length];
            // Copy character by character into array 
for(int inicio = 0; inicio < digitosIngresados.Length; inicio++)
            {
                    array1[inicio] = (char)digitosIngresados[inicio];
                if (array1[inicio] % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImPares++;
                }
            }

            MessageBox.Show("Pares: "+ contadorPares.ToString()+ "\nImPares: " + contadorImPares.ToString());
        }
    }
}
