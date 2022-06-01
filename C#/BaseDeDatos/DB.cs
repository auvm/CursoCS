using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public abstract class DB
    {
        //cadena de conexión
        private string _connectionstring;
        //variable de conexión
        protected SqlConnection _connection;

        /*
         * se requiere...
         * un servidor
         * el nombre de la base de datos
         * el usuario
         * la contraseña
         */

        public DB(string server, string db, string user, string password)
        {
            //La cadena de conexión cambia dependiendo el 
            //servidor de base de datos(mariadb, mysql, sql server)...
            
            //ESTA ES PARA SQL SERVER
            /*_connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user}; Password={password}; TRUSTED_CONNECTION = TRUE";*/
            _connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user}; Password={password};";
   
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }

        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();

        }
    }
}
