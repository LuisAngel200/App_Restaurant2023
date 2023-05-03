using Datos;
using System;
using System.Data;

namespace Negocio
{
    public class cls_EstadoPlato
    {
        private DataTable dte;
        public void fnt_CargarEstado()
        {
            cls_platos obj_Cargarestado = new cls_platos();
            obj_Cargarestado.fnt_CargarEstado();
            this.dte = obj_Cargarestado.getdtE();
        }
        public DataTable getdte() { return this.dte; }
    }
}
