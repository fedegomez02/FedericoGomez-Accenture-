using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsPracticas.loops_y_vectores.frmStruct;
using Microsoft.VisualBasic;

namespace WindowsPracticas.loops_y_vectores
{

    public partial class frmStruct : Form
    {
        public struct DatoOperario
        {
            public string Nombre;
            public double[] salario;
          
           
        }

    

    }

    public partial class Caso3 : Form
    {
        public Caso3()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            DatoOperario[] operario = new DatoOperario[4];
            for (int i = 0; i < operario.Length; i++)
            {
                string nombre = Interaction.InputBox("Nombre");
                nombre = operario[i].Nombre;
                operario[i].salario = new double[3];
                double contador;
                for (int j = 0; j < operario[i].salario.Length; j++)
                {
                    double sueldo = Convert.ToDouble(Interaction.InputBox("Ingrese salario"));
                    operario[i].salario[j] = sueldo;
                }
            }
            double sueldo1 = Acumulador(operario[0].salario);
            double sueldo2 = Acumulador(operario[1].salario);
            double sueldo3 = Acumulador(operario[2].salario);
            double sueldo4 = Acumulador(operario[3].salario);
            double total = sueldo1 + sueldo2 + sueldo3 + sueldo4;
            double sueldoMax = maximo(sueldo1, sueldo2, sueldo3, sueldo4);
            ///total mas alto de los 4 operarios
            if (sueldoMax == sueldo1) { MessageBox.Show("El operario con ingreso mas alto es " + operario[0].salario); }
            else if (sueldoMax == sueldo2) { MessageBox.Show("El operario con ingreso mas alto es " + operario[1].salario); }
            else if (sueldoMax == sueldo3) { MessageBox.Show("El operario con ingreso mas alto es " + operario[2].salario); }
            else { MessageBox.Show("El operario con ingreso mas alto es " + operario[3].salario); }
            /// sueldo total de cada empleado 
            MessageBox.Show("El operario " + operario[0].Nombre + " registro un ingreso total de " + sueldo1);
            MessageBox.Show("El operario " + operario[1].Nombre + " registro un ingreso total de  " + sueldo2);
            MessageBox.Show("El operario " + operario[2].Nombre + " registro un ingreso total de" + sueldo3);
            MessageBox.Show("El operario " + operario[3].Nombre + " registro un ingreso total de" + sueldo4);
        }
        public double Acumulador(double[] saldo)
        {
            double contador =0;
            for (int i = 0; i < saldo.Length; i++)
            {
                contador += saldo[i]; 
            }
            return contador;
           MessageBox.Show("El numero total es " + contador);
        }
        public double maximo(double a,double b,double c,double d )
        {
           double mayor1 = Math.Max(a, b);
            double mayor2 = Math.Max(c, d);
            double mayorFinal = Math.Max(mayor1, mayor2);
            return mayorFinal;
        }
    }
}
