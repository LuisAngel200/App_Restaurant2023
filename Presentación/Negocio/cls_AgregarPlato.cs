using System;
using System.Runtime.Remoting.Messaging;
using Datos;

namespace Negocio
{
    public class cls_AgregarPlato
    {
        private string str_codigo;
        private string str_nombre;
        private string str_ingredientes;
        private string str_valor;
        private int int_tipo;
        private int int_estado;
        private string str_msn;//enviar mensajes a la capa de presentacion 


        public cls_AgregarPlato(string str_codigo, string str_nombre, string str_ingredientes, string str_valor,
       int int_tipo, int int_estado)
        {
            this.str_codigo = str_codigo;
            this.str_nombre = str_nombre;
            this.str_ingredientes = str_ingredientes;
            this.str_valor = str_valor;
            this.int_tipo = int_tipo;
            this.int_estado = int_estado;
            if (str_codigo == "" || str_nombre == "" || str_ingredientes == "" || str_valor == "")
            {
                str_msn = "Debe ingresar toda la informacion requerida";
            }
            else
            {
                cls_platos objGuardar = new cls_platos();
                objGuardar.fnt_Guardar
                    (str_codigo, str_nombre, str_ingredientes, str_valor, int_tipo,
                    int_estado);
                str_msn = "El plato " + str_nombre + " ha sido registrado";
            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
