using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cls_ConsultarCliente
    {
        private string str_nombre;
        private string str_apellido;
        private string str_direccion;
        private string str_msn;

        public void fnt_Consultar(string id)
        {
            cls_conexion objConectar = new cls_conexion();
            objConectar.fnt_Conectar();
            string SQLbuscar;
            SQLbuscar = "select Nombre as 'Cliente', Apellidos as 'Apellidos', Direccion as 'Direccion' from tbl_cliente where PKcodigo = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(SQLbuscar, objConectar.conex);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader lectura = cmd.ExecuteReader();
            if (lectura.Read() == true) 
            {
                str_nombre = lectura["Cliente"].ToString();
                str_apellido = lectura["Apellidos"].ToString();
                str_direccion = lectura["Direccion"].ToString();
                this.str_msn = "";
            }
            else
            {
                this.str_msn = "Este cliente no se encuentra registrado";
            }
            objConectar.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public string getDireccion() { return this.str_direccion; }
        public string getApellidos() { return this.str_apellido; }
        public string getMsn() { return this.str_msn; }
    }
}
