using Datos;
using Negocio;
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
    public partial class RegistroP : Form
    {
        public RegistroP()
        {
            InitializeComponent();
            fnt_CargarTipo();
            fnt_CargarEstado();
            fnt_nuevo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        //***********************************************************FUNCION CERRAR FORM********************************************************
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        //*************************************************************FUNCION GUARDAR PLATO***************************************************
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cls_AgregarPlato objAgregarPlato = new cls_AgregarPlato(txt_codigo.Text, txt_nombre.Text, txt_ingredientes.Text, txt_valor.Text, cbx_tipo.SelectedIndex+1, cbx_estado.SelectedIndex+1);
            MessageBox.Show("" + objAgregarPlato.getMsn());
            fnt_nuevo();
        }

        //***********************************************************FUNCION CARGAR TIPO DE PLATO***********************************************
        private void fnt_CargarTipo()
        {
            cls_platos objdt = new cls_platos();
            objdt.fnt_CargarTipo();
            cbx_tipo.ValueMember = "PKCodigo";
            cbx_tipo.DisplayMember = "Nombre";
            cbx_tipo.DataSource = objdt.GetDt();
        }

        //***********************************************************FUNCION CARGAR ESTADO DEL PLATO***********************************************
        private void fnt_CargarEstado()
        {
            cls_platos obj_Cargarestado = new cls_platos();
            obj_Cargarestado.fnt_CargarEstado();
            cbx_estado.ValueMember = "PKCodigo";
            cbx_estado.DisplayMember = "Descripcion";
            cbx_estado.DataSource = obj_Cargarestado.getdtE();
        }

        //***********************************************************FUNCION BORRAR O NUEVO*******************************************************+
        private void fnt_nuevo()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_ingredientes.Clear();
            txt_valor.Clear();
            cbx_tipo.SelectedIndex = 0;
            cbx_estado.SelectedIndex = 0;
            txt_codigo.Focus();
        }
        private void ptb_nuevo_Click(object sender, EventArgs e)
        {
            fnt_nuevo();    
        }

        //***********************************************************FUNCION ACTUALIZAR************************************************************
        private void ptb_actualizar_Click(object sender, EventArgs e)
        {
            cls_ActualizarPlato objActualizar = new cls_ActualizarPlato(
                txt_codigo.Text, txt_nombre.Text, txt_ingredientes.Text, txt_valor.Text, cbx_tipo.SelectedIndex+1, cbx_estado.SelectedIndex+1);
            MessageBox.Show("" + objActualizar.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_nuevo();
        }

        //***********************************************************FUNCION CONSULTAR**************************************************************
        private void fnt_Consultar(string codigo)
        {
            cls_ConsultarPlato obj_Consultar = new cls_ConsultarPlato();
            obj_Consultar.fnt_Consultar(codigo);
            txt_nombre.Text = obj_Consultar.getNombre();
            txt_ingredientes.Text = obj_Consultar.getIngredientes();
            txt_valor.Text = obj_Consultar.getValor();
            cbx_tipo.SelectedIndex = obj_Consultar.getTipo() - 1;
            cbx_estado.SelectedIndex = obj_Consultar.getEstado() - 1;
        }
        private void ptb_consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar(txt_codigo.Text);
        }
    }
}
