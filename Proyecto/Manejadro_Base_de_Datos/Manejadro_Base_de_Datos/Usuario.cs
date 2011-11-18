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
                DataSet sqlServerDataSet = new DataSet();
                
                sqlServerCommand.CommandText = "Select name From sys.databases";
                sqlServerDataAdapter.SelectCommand = sqlServerCommand;
                sqlServerCommand.ExecuteNonQuery();
                sqlServerDataAdapter.Fill(sqlServerDataSet);
                return sqlServerDataSet;
            }


            return null;
        }

        public DataSet obtenerTablas(string strBasedeDatos)
        {
            if(tipoServidor == (int) enumTipo.SQLServer)
            {
                DataSet sqlServerDataSet = new DataSet() ;

                sqlServerCommand.CommandText = "Use "+strBasedeDatos+"";                               
                sqlServerCommand.ExecuteNonQuery();
                sqlServerCommand.CommandText = "select name from sys.tables";
                sqlServerCommand.ExecuteNonQuery();
                sqlServerDataAdapter.Fill(sqlServerDataSet);
                sqlServerCommand.CommandText = "Use master";
                sqlServerCommand.ExecuteNonQuery();

                return sqlServerDataSet;
            }

            return null;
        }

        //Crea una base de datos
        public void crearBasedeDatos(string nombre)
        {
            if (tipoServidor == (int)enumTipo.SQLServer)
            {               
                sqlServerCommand.CommandText = "create database " + nombre + "";
                sqlServerCommand.ExecuteNonQuery();
            }

        }

        public void eliminarBasedeDatos(string nombre)
        {
            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                sqlServerCommand.CommandText = "drop database " + nombre + "";
                sqlServerCommand.ExecuteNonQuery();
            }

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
