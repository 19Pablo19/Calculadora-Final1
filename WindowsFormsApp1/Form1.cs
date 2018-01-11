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


        String operacion;
        double operando1;
        double operando2;

        public Form1()
        {
            InitializeComponent();
        }

        //Recogo el numero pulsado y le añado su valor a la pantalla
        public void cambiaPantalla(Button numero)
        {
            if (pantalla.Text != "0")
            {
                pantalla.Text += numero.Text;
            }
            else
            {
                pantalla.Text = numero.Text;
            }
        }

        //Recoge el numero introducido y lo guarda en la variable operando1, pone la pantalla a 0
        public void realizaOperacion()
        { 
            //Solo lo realiza se no se ha dado anteriormente la orden de la operacion
            if(pantalla.Text != "0") 
            {
                operando1 = Convert.ToInt32(pantalla.Text);
                pantalla.Text = "0";
            }
            else
            {
                pantalla.Text = pantalla.Text;
            }
            
        }

        //Recoge el segundo operando y realiza la operacion
        public void dameResultado()
        {
            operando2 = Convert.ToInt32(pantalla.Text);

            switch (operacion)
            {
                case "+": pantalla.Text = Convert.ToString(operando1 + operando2); break;
                case "-": pantalla.Text = Convert.ToString(operando1 - operando2); break;
                case "*": pantalla.Text = Convert.ToString(operando1 * operando2); break;
                case "/": pantalla.Text = Convert.ToString(operando1 / operando2); break;
            }

        }

        //Reinicia todos los valores
        public void resetea()
        {
            pantalla.Text = "0";
            operando1 = 0;
            operando2 = 0;
            operacion = "";
        }

        //Pone el valor de la pantalla a 0
        public void borra()
        {
           
                pantalla.Text = "0";
            
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn1);
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            realizaOperacion();

            operacion = "+";
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            dameResultado();
        }

        private void botonMultiplacacion_Click(object sender, EventArgs e)
        {
            realizaOperacion();
            operacion = "*";
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            realizaOperacion();
            operacion = "-";
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            realizaOperacion();
            operacion = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn8);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn6);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            cambiaPantalla(btn0);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            resetea();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            borra();
        }
    }
}
