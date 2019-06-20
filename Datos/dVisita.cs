using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dVisita
    {
        Database db = new Database();
        public string Insertar(eVisita o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Visita(FechaVisita,CodigoAsunto) values('{0}','{1}')",o.FechaVisita,o.CodigoAsunto.CodigoAsunto);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }

        }
        public string Modificar(eVisita o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update visita set FechaVisita='{0}',CodigoAsunto='{1}'where CodigoVisita={2}", o.FechaVisita,o.CodigoAsunto,o.CodigoVisita);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from visita where CodigoVisita={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Elimino";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

    }
}
