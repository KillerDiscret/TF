using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    //Objetivo:Brindar la conexión a la BD
    public class Database
    {
        private SqlConnection conn;

        public SqlConnection ConectaDb()
        {
            try
            {
                //Integrated Security=true  (Significa que están conectando al SQL SERVER)
                // con Autenticación Windows
                string cadenadeconexion = "Data Source= PC_ASUS;Initial Catalog=dbVeterinaria;Integrated Security=True ";
                conn = new SqlConnection(cadenadeconexion);
                conn.Open();
                return conn;
            }
            catch(SqlException e)
            {
                return null;
            }
        }
        public void DesconectaDB()
        {
            conn.Close();
        }
    }
}
