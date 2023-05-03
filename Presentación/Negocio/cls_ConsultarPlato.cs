using Datos;
using System;

namespace Negocio
{
    public class cls_ConsultarPlato
    {
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        public void fnt_Consultar(string codigo)
        {
            Console.WriteLine(codigo);
            cls_platos obj_Consultar = new cls_platos();
            obj_Consultar.fnt_Consultar(codigo);
            this.str_nombre = obj_Consultar.getNombre();
            this.str_ingredientes = obj_Consultar.getIngredientes();
            this.str_valor = obj_Consultar.getValor();
            this.int_tipo = obj_Consultar.getTipo();
            this.int_estado = obj_Consultar.getEstado();

        }
        public string getNombre() { return this.str_nombre; }
        public string getIngredientes() { return this.str_ingredientes; }
        public string getValor() { return this.str_valor; }
        public int getTipo() { return this.int_tipo; }
        public int getEstado() { return this.int_estado; }
    }
}

