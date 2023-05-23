using Negocio;
using Datos;
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
    public partial class RegistroC : Form
    {
        public RegistroC()
        {
            InitializeComponent();
            fnt_Nuevo();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //************************************************************************FUNCION BORRAR O NUEVO**********************************************************
        private void fnt_Nuevo()
        {
            txt_codigoC.Clear();
            txt_nombreC.Clear();
            txt_apellidosC.Clear();
            txt_contactoC.Clear();
            txt_direccionC.Clear();
            txt_codigoC.Focus();
        }
        private void ptb_Nuevo_Click(object sender, EventArgs e)
        {
            fnt_Nuevo();
            txt_codigoC.Enabled = true;
            txt_codigoC.Focus();
        }

        //********************************************************************FUNCION GUARDAR CLIENTE**********************************************************
        private void ptb_GuardarC_Click(object sender, EventArgs e)
        {
            cls_AgregarCliente objAgregarCliente = new cls_AgregarCliente(txt_codigoC.Text, txt_nombreC.Text, txt_apellidosC.Text, txt_contactoC.Text, txt_direccionC.Text);
            MessageBox.Show("" + objAgregarCliente.getMsn());
            fnt_Nuevo();
        }

        //******************************************************************FUNCION CONSULTAR CLIENTE*************************************************************
        private void fnt_ConsultarC(string codigo)
        {
            cls_ConsultarClientes objConsultar = new cls_ConsultarClientes();
            objConsultar.fnt_ConsultarC(codigo);
            txt_nombreC.Text = objConsultar.getNombre();
            txt_apellidosC.Text = objConsultar.getApellidos();
            txt_contactoC.Text = objConsultar.getContacto();
            txt_direccionC.Text = objConsultar.getDireccion();
        }
        private void ptb_ConsultarC_Click(object sender, EventArgs e)
        {
            fnt_ConsultarC(txt_codigoC.Text);
            txt_codigoC.Enabled = false;
        }

        //***************************************************************FUNCION ACTUALIZAR CLIENTE********************************************************************
        private void ptb_ActualizarC_Click(object sender, EventArgs e)
        {
            cls_ActualizarCliente obj_Actualizar = new cls_ActualizarCliente(
               txt_codigoC.Text, txt_nombreC.Text, txt_apellidosC.Text, txt_contactoC.Text, txt_direccionC.Text);
            MessageBox.Show("" + obj_Actualizar.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_Nuevo();
        }

        //**************************************************************FUNCION CERRAR FORM*************************************************************************
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
