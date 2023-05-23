using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Windows.Forms;

namespace App_Restaurante
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {

        }

        private void txt_documento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_ConsultarCliente obj_Consultar = new cls_ConsultarCliente();
                obj_Consultar.fnt_Consultar(txt_documento.Text);
                txt_Nombre.Text = obj_Consultar.getNombre() + " " + obj_Consultar.getApellidos();
                txt_direccion.Text = obj_Consultar.getDireccion();
                if (obj_Consultar.getMsn() != "")
                {
                    MessageBox.Show("" + obj_Consultar.getMsn(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_ConsultarPlatos obj_consultarP = new cls_ConsultarPlatos();
                obj_consultarP.fnt_Consultar(txt_Codigo.Text);
                txt_Descripcion.Text = obj_consultarP.getIngredientes();
                txt_Existencias.Text = Convert.ToString(obj_consultarP.getNombre());
                txt_Valor.Text = Convert.ToString(obj_consultarP.getPrecio());
                if (obj_consultarP.getMensaje() != "")
                {
                    MessageBox.Show("" + obj_consultarP.getMensaje(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
