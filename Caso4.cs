using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticas.loops_y_vectores
{
    public partial class Caso4 : Form
    {
        public Caso4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = textBox1.Text;
            string nombre2 = textBox2.Text;
            string nombre3 = textBox3.Text;
            string nombre4 = textBox4.Text;
            string nombre5 = textBox5.Text;
            int edad1 = Convert.ToInt32(txtedad1.Text);
            int edad2 = Convert.ToInt32(txtedad2.Text);
            int edad3 = Convert.ToInt32(txtedad3.Text);
            int edad4 = Convert.ToInt32(txtedad4.Text);
            int edad5 = Convert.ToInt32(txtedad5.Text);


            string[] nombres = { nombre1, nombre2, nombre3, nombre4, nombre5 };
            int[] edad = { edad1, edad2, edad3, edad4, edad5 };

            MayorEdad(nombres, edad);
        }

        public void MayorEdad(string[] nombres, int[] edad)
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edad[i] >= 18)
                {
                    MessageBox.Show("Es mayor: " + nombres[i]);

                }

            }

        }
    }
}
