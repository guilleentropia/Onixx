using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NEmpleado
    {

        public static string Insertar(string apellido, string nombre,
                         int dni, string domicilio, int celular, string mail,
                         int idempresa)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Apellido = apellido;
            Obj.Nombre = nombre;
            Obj.DNI = dni;
            Obj.Domicilio = domicilio;
            Obj.Celular = celular;
            Obj.Mail = mail;
            Obj.IdEmpresa = idempresa;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int id, string apellido, string nombre,
                         int dni, string domicilio, int celular, string mail,
                         int idempresa)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.IdEmpleado = id;
            Obj.Apellido = apellido;
            Obj.Nombre = nombre;
            Obj.DNI = dni;
            Obj.Domicilio = domicilio;
            Obj.Celular = celular;
            Obj.Mail = mail;
            Obj.IdEmpresa = idempresa;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int id)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.IdEmpleado = id;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DEmpleado().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.Buscar(Obj);
        }
    }
}
