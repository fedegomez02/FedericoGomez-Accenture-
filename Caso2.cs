using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsPracticas.loops_y_vectores
{
    public partial class Caso2 : Form
    {
        int[] numeros;
       
        public Caso2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("el precio total es " );
        }

        public void Acumulador()
        {
            int contador = 0;
            numeros = new int[8];
            for (int j = 0; j < numeros.Length; j++)
            {


                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número"));
                contador += numero;
                numeros[j] = numero;
            }
        }


    }
}
