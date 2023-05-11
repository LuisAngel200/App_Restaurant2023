using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*********************************************************************FUNCIONES FORM*****************************************************
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form4 formulario = new Form4();
            formulario.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form2 formulario = new Form2();
            formulario.Visible = true;  
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form3 formulario = new Form3();
            formulario.Visible = true;
        }

        //********************************************************FUNCIONES CERRAR FORM********************************************************
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
