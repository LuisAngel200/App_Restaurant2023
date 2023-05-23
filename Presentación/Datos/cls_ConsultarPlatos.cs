using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_ConsultarPlatos
    {
        private string str_Nombre;
        private float flt_ValorU;
        private string str_Ingredientes;
        private string str_msn;

        public void fnt_Consultar(string codigo)
        {
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_Conectar();
            string SQLbuscar;
            SQLbuscar = "select Nombre as 'Nombre', Ingredientes as 'Ingredientes', Valor as 'Valor' from tbl_platos where PKCodigo = '" + codigo + "' and FKCodigo_tbl_estado = '1'";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, obj_Conectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if(lectura.Read() == true )
            {
                str_Nombre = lectura["Nombre"].ToString();
                str_Ingredientes = (lectura["Ingredientes"].ToString());
                flt_ValorU = Convert.ToInt32(lectura["Valor"].ToString());
                this.str_msn = "";
            }
            else
            {
                this.str_msn = "Producto no disponible/ o no se encuentra registrado";
            }
            obj_Conectar.fnt_Desconectar();
        }
        public string getMensaje() { return this.str_msn; }
        public string getNombre() { return this.str_Nombre;}
        public float getPrecio() { return this.flt_ValorU; }
        public string getIngredientes() { return this.str_Ingredientes;}
    }
}
