using Datos;
using System;
using System.Data;

namespace Negocio
{
    public class cls_TipoPlato
    {
        private DataTable dt;
        public void fnt_CargarTipo()
        {
            cls_platos objDt = new cls_platos();
            objDt.fnt_CargarTipo();
            this.dt = objDt.GetDt();
        }
        public DataTable getDt() { return this.dt; }

    }

}

