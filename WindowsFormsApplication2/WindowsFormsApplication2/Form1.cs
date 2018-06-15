using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private int cont1;
        private int cont2;
        private int cont3;
        private int total;
        private float porcentaje1;
        private float porcentaje2;
        private float porcentaje3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;
            num1 = Convert.ToSingle(textBox1.Text);
            num2 = Convert.ToSingle(textBox2.Text);
            num3 = Convert.ToSingle(textBox3.Text);

            if (num1 == num2 && num1 == num3)
            {
                label4.Text = "TRIANGULO EQUILATERO";
                cont1++;
                label8.Text = Convert.ToString(cont1); 
            }
            else if (num1 == num2 || num1 == num3 || num2 ==num3 )
            {
                label4.Text = "TRIANGULO ISOSCELES";
                cont2++;
                label9.Text = Convert.ToString(cont2);
            }
            else if ( num1 != num2 && num1 != num3 && num2 != num3){
                label4.Text = "TRIANGULO ESCALENO";
                cont3++;
                label10.Text = Convert.ToString(cont3);
            }

            total = cont1 + cont2 + cont3 ;
            label15.Text = Convert.ToString(total);
                        
            porcentaje1 = (float)(cont1*100 / total);
            label11.Text = Convert.ToString(porcentaje1+"%");
            
            porcentaje2 = (float)(cont2 * 100 / total) ;
            label12.Text = Convert.ToString(porcentaje2+"%");

            porcentaje3 = (float)(cont3 * 100 / total) ;
            label13.Text = Convert.ToString(porcentaje3+"%");


            label16.Text = Convert.ToString(porcentaje1+porcentaje2+porcentaje3 + "%");
            
            
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cont1 = cont2 = cont3 = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
