using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using static Datos.cls_conexion;
namespace Datos
{
    public class cls_clientes
    {
        private string str_codigo;
        private string str_nombre;
        private string str_apellidos;
        private string str_contacto;
        private string str_direccion;

        public void fnt_GuardarC(string codigo, string nombre, string apellidos, string contacto, string direccion)
        {
            cls_conexion obj_Conexion = new cls_conexion();
            obj_Conexion.fnt_Conectar();
            string comando = "insert into tbl_cliente (@PKCodigo, @Nombre, @Apellidos, @Contacto, @Direccion)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_Conexion.conex);
            cmd.Parameters.AddWithValue("@PKCodigo", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.ExecuteNonQuery();
            obj_Conexion.fnt_Desconectar();
        }

        public void fnt_ConsultarC(string codigo)
        {
            Console.WriteLine("ID" + codigo);
            String sql = "select Nombre,Apellidos,Contacto,Direccion = '" + codigo + "'";
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_Conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                str_nombre = reader["Nombre"].ToString();
                str_apellidos = reader["Apellidos"].ToString();
                str_contacto = reader["Contacto"].ToString();
                str_direccion = reader["Direccion"].ToString();
                Console.WriteLine("Nombre: " + str_nombre);
            }
            obj_Conectar.fnt_Desconectar();
        }

        public void fnt_ActualizarC(string codigo, string nombre, string apellidos, string contacto, string direccion)

        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_Conectar();
            string comando = "update tbl_platos set nombre=@nombre, ingredientes=@ingredientes, valor=@valor, FKCodigo_tbl_tipo=@FKCodigo_tbl_tipo, " +
                "FKCodigo_tbl_estado=@FKCodigo_tbl_estado where PKCodigo=@PKCodigo";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCodigo", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Contacto", contacto);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public string getApellidos() { return this.str_apellidos; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }

    }
}

