using System;
using System.Runtime.Remoting.Messaging;
using Datos;
namespace Negocio
{
    public class cls_AgregarCliente
    {
        private string str_codigo;
        private string str_nombre;
        private string str_apellidos;
        private string str_contacto;
        private string str_direccion;
        private string str_msn;//enviar mensajes a la capa de presentacion 


        public cls_AgregarCliente(string str_codigo, string str_nombre, string str_apellidos, string str_contacto,
       string str_direccion)
        {
            this.str_codigo = str_codigo;
            this.str_nombre = str_nombre;
            this.str_apellidos = str_apellidos;
            this.str_contacto = str_contacto;
            this.str_direccion = str_direccion;
            if (str_codigo == "" || str_nombre == "" || str_apellidos == "" || str_contacto == "" || str_direccion == "")
            {
                str_msn = "Debe ingresar toda la informacion requerida";
            }
            else
            {
                cls_clientes obj_Guardar = new cls_clientes();
                obj_Guardar.fnt_GuardarC
                    (str_codigo, str_nombre, str_apellidos, str_contacto, str_direccion);
                str_msn = "El cliente " + str_nombre + " ha sido registrado";
            }
        }
        public string getMsn() { return this.str_msn; }
    }
}
