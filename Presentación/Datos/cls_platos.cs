using MySql.Data.MySqlClient;
using System;
using System.Data;
using static Datos.cls_conexion;

namespace Datos
{
    public class cls_platos
    {
        private DataTable dt;
        private DataTable dte;
        private string str_codigo;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        //Funcion Guardar
        public void fnt_Guardar(
            string codigo, string nombre, string ingredientes, string valor, int tipo, int estado)
        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_Conectar();
            string comando = "insert into tbl_platos values (@PKCodigo, @Nombre, @Ingredientes, @Valor, @FKCodigo_tbl_tipo, @FKCodigo_tbl_estado)";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCodigo", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Ingredientes", ingredientes);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }

        public void fnt_CargarTipo()
        {
            string sql = "select PKCodigo,Nombre from tbl_tipo";
            cls_conexion objConecta = new cls_conexion();
            objConecta.fnt_Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objConecta.conex);
                dt = new DataTable();
                MySqlDataAdapter Data = new MySqlDataAdapter(comando);
                Data.Fill(dt);
            }
            catch (Exception)
            {
                objConecta.fnt_Desconectar();
            }
        }
        public DataTable GetDt() { return dt; }

        public void fnt_CargarEstado()
        {
            string sql = "select PKCodigo,Descripcion from tbl_estado";
            cls_conexion objCargarestado = new cls_conexion();
            objCargarestado.fnt_Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, objCargarestado.conex);
                dte = new DataTable();
                MySqlDataAdapter objDatae = new MySqlDataAdapter(comando);
                objDatae.Fill(dte);
            }
            catch (Exception)
            {
                objCargarestado.fnt_Desconectar();
            }
        }
       
        public void fnt_Consultar(string codigo)
        {
            Console.WriteLine("ID" + codigo);
            String sql = "select Nombre,Ingredientes,Valor,FKCodigo_tbl_tipo,FKCodigo_tbl_estado from tbl_platos where PKCodigo = '" + codigo + "'";
            cls_conexion obj_Conectar = new cls_conexion();
            obj_Conectar.fnt_Conectar();

            MySqlCommand comando = new MySqlCommand(sql, obj_Conectar.conex);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                str_nombre = reader["Nombre"].ToString();
                str_ingredientes = reader["Ingredientes"].ToString();
                str_valor = reader["Valor"].ToString();
                int_tipo = Convert.ToInt16(reader["FKCodigo_tbl_tipo"].ToString());
                int_estado = Convert.ToInt16(reader["FKCodigo_tbl_estado"].ToString());
                Console.WriteLine("Nombre: " + str_nombre);
            }

            obj_Conectar.fnt_Desconectar();
        }
        public void fnt_Actualizar(string codigo, string nombre, string ingredientes, string valor, int tipo, int estado)

        {
            cls_conexion obj_conexion = new cls_conexion();
            obj_conexion.fnt_Conectar();
            string comando = "update tbl_platos set nombre=@nombre, ingredientes=@ingredientes, valor=@valor, FKCodigo_tbl_tipo=@FKCodigo_tbl_tipo, " +
                "FKCodigo_tbl_estado=@FKCodigo_tbl_estado where PKCodigo=@PKCodigo";
            MySqlCommand cmd = new MySqlCommand(comando, obj_conexion.conex);
            cmd.Parameters.AddWithValue("@PKCodigo", codigo);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Ingredientes", ingredientes);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_tipo", tipo);
            cmd.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
            cmd.ExecuteNonQuery();
            obj_conexion.fnt_Desconectar();
        }
        public string getNombre() { return this.str_nombre; }
        public string getIngredientes() { return this.str_ingredientes; }
        public string getValor() { return this.str_valor; }
        public int getTipo() { return this.int_tipo; }
        public int getEstado() { return this.int_estado; }
        public DataTable getdtE()
        {
            return dte;
        }
    }
}
