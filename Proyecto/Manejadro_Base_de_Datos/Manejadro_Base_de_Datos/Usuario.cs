using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Manejadro_Base_de_Datos
{
    class Usuario
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
        private SqlConnection sqlServerConnection;
        private SqlCommand sqlServerCommand;

        //Constructor de la clase.
        public Usuario(String strUsuario, String strPassword,int TipoBD)
        {
            if (TipoBD == (int)enumTipo.SQLServer)
            {
                strConeccion = "Data Source = localhost; User Id = "+strUsuario+"; Password="+strPassword+";";                
                sqlServerConnection = new SqlConnection(strConeccion);
                sqlServerConnection.Open();
            }
        }

    }
}
