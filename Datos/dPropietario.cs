using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;


namespace Datos
{
   public class dPropietario
    {
        Database db = new Database();

        public string Insertar(ePropietario o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("INSERT INTO ePropietario(Nombre,FechaRegistro,DNI,Direccion,Telf,Cel,Distrito,Observaciones,CodigoMascota) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", o.Nombre,o.FechaRegistro,o.DNI,o.Direccion,o.Telf,o.Cel,o.Distrito,o.Observaciones,o.CodigoMascota.CodigoMascota);
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
        public string Modificar(ePropietario o)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("UPDATE ePropietario SET Nombre='{0}',FechaRegistro='{1}',DNI='{2}',Direccion='{3}',Telf='{4}',Cel='{5}',Distrito='{6}',Observaciones='{7}',CodigoMascota='{8}' where CodigoPropietario={9}", o.Nombre, o.FechaRegistro, o.DNI, o.Direccion, o.Telf, o.Cel, o.Distrito, o.Observaciones, o.CodigoMascota.CodigoMascota, o.CodigoPropietario);
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
                string delete = string.Format("DELETE from ePropietario WHERE CodigoPropietario={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Elimino";
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
        

    }
}
