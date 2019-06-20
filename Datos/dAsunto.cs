using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;
namespace Datos
{
   public class dAsunto
    {
        Database db = new Database();
        public string Insertar(eAsunto o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into asunto(Motivo,Observacion) values('{0}','{1}')",o.Motivo,o.Observacion);
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
        public string Modificar(eAsunto o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update asunto set Motivo='{0}',Observacion='{1}' where CodigoAsunto={2}",o.Motivo,o.Observacion,o.CodigoAsunto);
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
                string delete = string.Format("delete from Asunto where CodigoAsunto={0}", id);
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
