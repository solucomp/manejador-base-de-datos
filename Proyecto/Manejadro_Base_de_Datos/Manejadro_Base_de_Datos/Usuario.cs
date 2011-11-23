using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data.SQLite;

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
      
        //objetos necesarios para MySql
        private MySqlConnection MysqlConnection;
        private MySqlCommand MysqlCommand;
        private MySqlDataAdapter MysqlDataAdapter;

        //objetos necesarios para Access
        private OleDbConnection accessConection;
        private OleDbCommand accessCommand;
        private OleDbDataAdapter accessAdapter;

        //objetos necesarios para SQLite
        private SQLiteCommand sqliteCommand;
        private SQLiteConnection sqliteConnection;
        private SQLiteDataAdapter sqliteDataAdapteer;

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
                strConeccion = "server=localhost;user=root;port=3306;password=default;";
                MysqlConnection = new MySqlConnection(strConeccion);
                MysqlConnection.Open();
                MysqlCommand = new MySqlCommand();
                MysqlDataAdapter = new MySqlDataAdapter();
                MysqlCommand.Connection = MysqlConnection;
            }
            //Abrir la coneccion a SQLite
            if (tipoServidor == (int)enumTipo.SQLite)
            {
                strConeccion = "Data Source=personal.sqlite;Version=3;New=False;Compress=True;";
                sqliteConnection = new SQLiteConnection(strConeccion);
                sqliteConnection.Open();
                sqliteCommand = new SQLiteCommand();
                sqliteDataAdapteer = new SQLiteDataAdapter();
                sqliteCommand.Connection = sqliteConnection;
            }
            //Abrir la coneccion a Access
            if (tipoServidor == (int)enumTipo.Access)
            {
                strConeccion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=|DataDirectory|\\Database1.accdb;";
                accessConection = new OleDbConnection(strConeccion);
                accessConection.Open();
                accessCommand= new OleDbCommand();
                accessAdapter= new OleDbDataAdapter();
                accessCommand.Connection = accessConection;
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
            if (tipoServidor == (int)enumTipo.SQLite)
            {
                DataSet sqliteDataSet = new DataSet();

                sqliteCommand.CommandText = "select name from sys.databases";
                sqliteDataAdapteer.SelectCommand = sqliteCommand;
                sqliteCommand.ExecuteNonQuery();
                sqliteDataAdapteer.Fill(sqliteDataSet);
                return sqliteDataSet;
            }
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                DataSet MySqlDataSet = new DataSet();

                MysqlCommand.CommandText = "select SCHEMA_NAME from information_schema.SCHEMATA;";
                MysqlDataAdapter.SelectCommand = MysqlCommand;
                MysqlCommand.ExecuteNonQuery();
                MysqlDataAdapter.Fill(MySqlDataSet);
                return MySqlDataSet;
            }
            if (tipoServidor == (int)enumTipo.Access)
            {
                DataSet accesDataset = new DataSet();

                accessCommand.CommandText= "select name from sys.databases";
                accessAdapter.SelectCommand = accessCommand;
                accessCommand.ExecuteNonQuery();
                accessAdapter.Fill(accesDataset);
                return accesDataset;
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

            if (tipoServidor == (int)enumTipo.MySQL)
            {
                DataSet MySqlDataSet = new DataSet();

                MysqlCommand.CommandText = "use "+strBasedeDatos+";" ;
                MysqlCommand.ExecuteNonQuery();
                MysqlCommand.CommandText = "select table_name from information_schema.tables where table_schema='"+strBasedeDatos+"';";
                MysqlCommand.ExecuteNonQuery();
                MysqlDataAdapter.Fill(MySqlDataSet);
                //MysqlCommand.CommandText = "use pet;";
                //MysqlCommand.ExecuteNonQuery();

                return MySqlDataSet;
            }

            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                DataSet sqliteDataSet = new DataSet();

                sqliteCommand.CommandText = "use " + strBasedeDatos + ";";
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.CommandText = "select name from sys.tables";
                sqliteCommand.ExecuteNonQuery();
                sqliteDataAdapteer.Fill(sqliteDataSet);
                sqliteCommand.CommandText = "use master";
                sqliteCommand.ExecuteNonQuery();

                return sqliteDataSet;
            }

             if (tipoServidor == (int)enumTipo.Access)
            {
                DataSet accessDataset = new DataSet();

                accessCommand.CommandText = "use "+strBasedeDatos+";" ;
                accessCommand.ExecuteNonQuery();
                accessCommand.CommandText="Show tables;";
                accessCommand.ExecuteNonQuery();
                accessAdapter.Fill(accessDataset);
                accessCommand.CommandText="use master";
                accessCommand.ExecuteNonQuery();

                return accessDataset;
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
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                MysqlCommand.CommandText = "create database " + nombre + ";";
                MysqlCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                sqliteCommand.CommandText = "create database " + nombre + ";";
                sqliteCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.Access)
            {
                accessCommand.CommandText = "create database " + nombre + ";";
                accessCommand.ExecuteNonQuery();
            }

        }

        public void eliminarBasedeDatos(string nombre)
        {
            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                sqlServerCommand.CommandText = "drop database " + nombre + "";
                sqlServerCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                MysqlCommand.CommandText = "drop database " + nombre + ";";
                MysqlCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                sqliteCommand.CommandText = "drop database " + nombre + ";";
                sqliteCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.Access)
            {
                accessCommand.CommandText = "drop database " + nombre + ";";
                accessCommand.ExecuteNonQuery();
            }
        }

        public void eliminarTabla(string strBasedeDatos, string strTabla)
        {
            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                sqlServerCommand.CommandText = "use " +  strBasedeDatos;
                sqlServerCommand.ExecuteNonQuery();
                sqlServerCommand.CommandText = "drop table " + strTabla;
                sqlServerCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.Access)
            {
                accessCommand.CommandText= "use " +  strBasedeDatos;
                accessCommand.ExecuteNonQuery();
                accessCommand.CommandText = "drop table " + strTabla;
                accessCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                sqliteCommand.CommandText = "use " + strBasedeDatos;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.CommandText = "drop table " + strTabla;
                sqliteCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                MysqlCommand.CommandText = "use " + strBasedeDatos;
                MysqlCommand.ExecuteNonQuery();
                MysqlCommand.CommandText = "drop table " + strTabla;
                MysqlCommand.ExecuteNonQuery();
            }
        }

        public void crearTabla(string nombre, string BasedeDatos, List<string> listaCampos)
        {


            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                string strQuery = "CREATE TABLE " + nombre + " ( ";

                int counter = 0;
                foreach (string str in listaCampos)
                {
                    if (counter < listaCampos.Count - 1)
                    {
                        strQuery += str + ",";
                    }
                    else
                    {
                        strQuery += str + ")";
                    }
                    counter++;
                }

                sqlServerCommand.CommandText = "use "+BasedeDatos;
                sqlServerCommand.ExecuteNonQuery();
                sqlServerCommand.CommandText = strQuery;
                sqlServerCommand.ExecuteNonQuery();
                sqlServerCommand.CommandText = "use master";
                sqlServerCommand.ExecuteNonQuery();

            }

            if (tipoServidor == (int)enumTipo.Access)
            {
                string strQuery = "CREATE TABLE " + nombre + " ( ";

                int counter = 0;
                foreach (string str in listaCampos)
                {
                    if (counter < listaCampos.Count - 1)
                    {
                        strQuery += str + ",";
                    }
                    else
                    {
                        strQuery += str + ")";
                    }
                    counter++;
                }

                accessCommand.CommandText = "use "+BasedeDatos;
                accessCommand.ExecuteNonQuery();
                accessCommand.CommandText = strQuery;
                accessCommand.ExecuteNonQuery();
                accessCommand.CommandText = "use master";
                accessCommand.ExecuteNonQuery();

            }
            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                string strQuery = "CRATE TABLE " + nombre + " ( ";

                int counter = 0;
                foreach (string str in listaCampos) 
                {
                    if (counter < listaCampos.Count - 1)
                    {
                        strQuery += str + ",";
                    }
                    else
                    {
                        strQuery += str + ")";
                    }
                    counter++;
                }
                sqliteCommand.CommandText = "use " + BasedeDatos;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.CommandText = strQuery;
                sqliteCommand.ExecuteNonQuery();
                sqliteCommand.CommandText = "use master";
                sqliteCommand.ExecuteNonQuery();
            }
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                string strQuery = "CREATE TABLE " + nombre + " ( ";

                int counter = 0;
                foreach (string str in listaCampos)
                {
                    if (counter < listaCampos.Count - 1)
                    {
                        strQuery += str + ",";
                    }
                    else
                    {
                        strQuery += str + ")";
                    }
                    counter++;
                }
                MysqlCommand.CommandText = "use " + BasedeDatos;
                MysqlCommand.ExecuteNonQuery();
                MysqlCommand.CommandText = strQuery;
                MysqlCommand.ExecuteNonQuery();
            }

        }

        public void cerrarConexion()
        {

            if(tipoServidor == (int) enumTipo.SQLServer)
            {
                sqlServerConnection.Close();
            }
            if (tipoServidor == (int)enumTipo.MySQL)
            {
                MysqlConnection.Close();
            }
            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                sqliteConnection.Close();
            }
             if (tipoServidor == (int)enumTipo.Access)
            {
                accessConection.Close();
            }
        }

        public void crearTablas(string basededatos, string NombreTabla, string campos)
        {
            if (tipoServidor == (int)enumTipo.SQLServer)
            {
                sqlServerCommand.CommandText = "USE " + basededatos;
                sqlServerCommand.ExecuteNonQuery();

                sqlServerCommand.CommandText = "CREATE TABLE " + NombreTabla + "(" + campos + ")"; ;
                sqlServerCommand.ExecuteNonQuery();
            }

            if (tipoServidor == (int)enumTipo.Access)
            {
                accessCommand.CommandText = "USE " + basededatos;
                accessCommand.ExecuteNonQuery();

                accessCommand.CommandText = "CREATE TABLE " + NombreTabla + "(" + campos + ")"; ;
                accessCommand.ExecuteNonQuery();
            }

            if (tipoServidor == (int)enumTipo.SQLite) 
            {
                sqliteCommand.CommandText = "USE " + basededatos;
                sqliteCommand.ExecuteNonQuery();

                sqliteCommand.CommandText = "CREATE TABLE " + NombreTabla + "(" + campos + ")"; ;
                sqliteCommand.ExecuteNonQuery();
            }
        }

    }
}
