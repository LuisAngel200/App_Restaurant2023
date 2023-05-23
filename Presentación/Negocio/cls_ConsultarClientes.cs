using Datos;
using System;

namespace Negocio
{
    public class cls_ConsultarClientes
    {
        private string str_nombre;
        private string str_apellidos;
        private string str_contacto;
        private string str_direccion;
        public void fnt_ConsultarC(string codigo)
        {
            Console.WriteLine(codigo);
            cls_clientes objConsultar = new cls_clientes();
            objConsultar.fnt_ConsultarC(codigo);
            this.str_nombre = objConsultar.getNombre();
            this.str_apellidos = objConsultar.getApellidos();
            this.str_contacto = objConsultar.getContacto();
            this.str_direccion = objConsultar.getDireccion();

        }
        public string getNombre() { return this.str_nombre; }
        public string getApellidos() { return this.str_apellidos; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }
    }
}
