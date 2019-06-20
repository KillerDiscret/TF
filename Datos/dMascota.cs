using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dMascota
    {
        Database db = new Database();
        public string Insertar(eMascota o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into mascota(Nombre,FechaRegistro,Tipo,Raza,Edad,Sexo,Esterelizado,Observaciones,CodigoVisita) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",o.Nombre,o.FechaRegistro,o.Tipo,o.Raza,o.Edad,o.Sexo,o.Esterelizado,o.Observaciones,o.CodigoVisita.CodigoVisita);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch(Exception ex )
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public string Modificar(eMascota o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update mascota set Nombre='{0}',FechaRegistro='{1}',Tipo={2},Raza={3},Edad={4},Sexo={5},Esterelizado={6},Observaciones={7},CodigoVisita={8} where CodigoMascota={9}",o.Nombre,o.FechaRegistro,o.Tipo,o.Raza,o.Edad,o.Sexo,o.Esterelizado,o.Observaciones,o.CodigoVisita,o.CodigoMascota);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico";

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
        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from Mascota where CodigoMascota={0}", id);
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
