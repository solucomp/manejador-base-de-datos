using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Manejadro_Base_de_Datos
{
    public class Usuario
    {
        //Datos de la clase
        public enum enumTipo
        {
            SQLServer = 1,
            MySQL = 2,
            SQLite = 3,
            Access = 4
        };
        public static String strConeccion;
        public int tipoServidor;

        //Objetos necesario para SQLServer
        private SqlConnection sqlServerConnection;
        private SqlCommand sqlServerCommand;
        private DataSet sqlServerDataSet;
        private SqlDataAdapter sqlServerDataAdapter;        

        //Constructor de la clase.
        public Usuario(String strUsuario, String strPassword,int TipoBD)
        {
            tipoServidor = TipoBD;
            //Abre la conexión al servidor seleccionado 
            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                strConeccion = "Data Source = localhost; User Id = "+strUsuario+"; Password="+strPassword+";";                
                sqlServerConnection = new SqlConnection(strConeccion);
                sqlServerConnection.Open();
                //Se inicializan los componentes
                sqlServerCommand = new SqlCommand();
                sqlServerDataSet = new DataSet();
                sqlServerDataAdapter = new SqlDataAdapter();
                sqlServerCommand.Connection = sqlServerConnection;
            }
            //Abrir la coneccion a MySQL
            if(tipoServidor == (int) enumTipo.MySQL)
            {

            }
            //Abrir la coneccion a SQLite
            if (tipoServidor == (int)enumTipo.SQLite)
            {

            }
            //Abrir la coneccion a Access
            if (tipoServidor == (int)enumTipo.Access)
            {

            }            

        }       

        public DataSet obtenerBasedeDatos()
        {
            if(tipoServidor == (int) enumTipo.SQLServer)
            {
                sqlServerDataSet.Clear();
                sqlServerCommand.CommandText = "Select name From sys.databases";
                sqlServerDataAdapter.SelectCommand = sqlServerCommand;
                sqlServerCommand.ExecuteNonQuery();
                sqlServerDataAdapter.Fill(sqlServerDataSet);
                return sqlServerDataSet;
            }


            return null;
        }

        public void cerrarConexion()
        {
            if(tipoServidor == (int) enumTipo.SQLServer)
            {
                sqlServerConnection.Close();
            }
        }

    }
}
