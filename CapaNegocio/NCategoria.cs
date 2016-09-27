using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NCategoria
    {
        public static string Insertar(string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int id, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.IdCategoria = id;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int id, string descripcion)
        {
            DCategoria Obj = new DCategoria();
            Obj.IdCategoria = id;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.Buscar(Obj);
        }



    }
}
