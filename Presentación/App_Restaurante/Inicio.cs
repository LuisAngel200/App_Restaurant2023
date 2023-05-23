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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //*********************************************************************FUNCIONES FORM*****************************************************
        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            RegistroC formulario = new RegistroC();
            formulario.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            RegistroP formulario = new RegistroP();
            formulario.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            Form formulario = new Facturas();
            formulario.ShowDialog();
        }

        //********************************************************FUNCIONES CERRAR FORM********************************************************
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
