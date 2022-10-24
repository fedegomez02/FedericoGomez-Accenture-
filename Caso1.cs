using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsPracticas.loops_y_vectores
{
    public partial class Caso1 : Form
    {
        int[] numeros;
        
        public Caso1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            

           

                for (int j = 0; j < 4; j++)
                {
                
                string nombree = Interaction.InputBox("ingrese nombre");
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número"));
                int numero2 = Convert.ToInt32(Interaction.InputBox("Ingrese número 2"));
                int numero3 = Convert.ToInt32(Interaction.InputBox("Ingrese número 3"));
                numeros = new int[3] { numero, numero2, numero3 };
                int notaALTA = calcualMax(numero, numero2, numero3);
                MessageBox.Show("las notas de " + nombree + " son " + numero + numero2 + numero3);
                MessageBox.Show("La nota mas alta de " + nombree + " es " + notaALTA);

                 if(notaALTA > 7){ MessageBox.Show("Muy bien");}
                 else if (notaALTA >4 && notaALTA<= 7) { MessageBox.Show("bien"); }
                else { MessageBox.Show("debe ir a recuperatorio"); }
                }
             

               

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            

            foreach (int item in numeros)
                {
                
                    listBox1.Items.Add(item);
                }
         

        }
        public int calcualMax(int n1,int n2,int n3 )
        {
            int result1 = Math.Max(n1, n2);
            int resultTotal = Math.Max(result1, n3);
            return resultTotal;
        }


        
    }
}
