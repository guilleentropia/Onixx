using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEmpleado
    {
        private int _IdEmpleado;
        private string _Apellido;
        private string _Nombre;
        private int _DNI;
        private string _Domicilio;
        private int _Celular;
        private string _Mail;
        private int _IdEmpresa;
        private string _TextoBuscar;


        public int IdEmpleado
        {
            get { return _IdEmpleado; }
            set { _IdEmpleado = value; }
        }
       

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
       

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        

        public string Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = value; }
        }
        

        public int Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }
        

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
        
        
        public int IdEmpresa
        {
            get { return _IdEmpresa; }
            set { _IdEmpresa = value; }
        }
                        

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        public DEmpleado()
        {

        }

        //Constructor con parametros
        public DEmpleado(int idempleado, string apellido, string nombre,
                         int dni, string domicilio, int celular, string mail,
                         int idempresa, string textobuscar)
        {
            this.IdEmpleado = idempleado;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dni;
            this.Domicilio = domicilio;
            this.Celular = celular;
            this.Mail = mail;
            this.IdEmpresa = idempresa;
            this.TextoBuscar = textobuscar;

        }


        //Metodo insertar
        public string Insertar(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@id";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.Int;
                ParDni.Value = Empleado.DNI;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParDomicilio = new SqlParameter();
                ParDomicilio.ParameterName = "@domicilio";
                ParDomicilio.SqlDbType = SqlDbType.VarChar;
                ParDomicilio.Size = 150;
                ParDomicilio.Value = Empleado.Domicilio;
                SqlCmd.Parameters.Add(ParDomicilio);


                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.Int;
                ParCelular.Value = Empleado.Celular;
                SqlCmd.Parameters.Add(ParCelular);


                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Empleado.Domicilio;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParEmpresaId = new SqlParameter();
                ParEmpresaId.ParameterName = "@idempresa";
                ParEmpresaId.SqlDbType = SqlDbType.Int;
                ParEmpresaId.Value = Empleado.IdEmpresa;
                SqlCmd.Parameters.Add(ParEmpresaId);






                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return rpta;
        }

        //Metodo editar
        public string Editar(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@id";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleado.IdEmpleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 50;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);


                SqlParameter ParDni = new SqlParameter();
                ParDni.ParameterName = "@dni";
                ParDni.SqlDbType = SqlDbType.Int;
                ParDni.Value = Empleado.DNI;
                SqlCmd.Parameters.Add(ParDni);

                SqlParameter ParDomicilio = new SqlParameter();
                ParDomicilio.ParameterName = "@domicilio";
                ParDomicilio.SqlDbType = SqlDbType.VarChar;
                ParDomicilio.Size = 150;
                ParDomicilio.Value = Empleado.Domicilio;
                SqlCmd.Parameters.Add(ParDomicilio);


                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.Int;
                ParCelular.Value = Empleado.Celular;
                SqlCmd.Parameters.Add(ParCelular);


                SqlParameter ParMail = new SqlParameter();
                ParMail.ParameterName = "@mail";
                ParMail.SqlDbType = SqlDbType.VarChar;
                ParMail.Size = 150;
                ParMail.Value = Empleado.Domicilio;
                SqlCmd.Parameters.Add(ParMail);

                SqlParameter ParEmpresaId = new SqlParameter();
                ParEmpresaId.ParameterName = "@idempresa";
                ParEmpresaId.SqlDbType = SqlDbType.Int;
                ParEmpresaId.Value = Empleado.IdEmpresa;
                SqlCmd.Parameters.Add(ParEmpresaId);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return rpta;
        }

        //Metodo eliminar
        public string Eliminar(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@id";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Empleado.IdEmpleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return rpta;

        }


        //Metodo mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Empleado");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }


        //Metodo buscar
        public DataTable Buscar(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("Empleado");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {

                DtResultado = null;
            }

            return DtResultado;

        }

    }
}
