using System;

using System.Data.SqlClient;
using System.Data;
using obligatorio.clases;

namespace obligatorio.persistencia
{
    public class PResponsable
    {
        private static Conexion con = new Conexion();

        public static Boolean AddResponsable(Responsable r)
        {
            string sql = "INSERT INTO Responsable (id, nombre, telefono) VALUES (@id, @nombre, @telefono)";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = r.Id },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = r.Nombre },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = r.Telefono },
            };


            Console.WriteLine("Ingresado con éxito");
            bool encontrado = con.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean UpdateResponsable(Responsable r)
        {
            string sql = "UPDATE Responsable SET nombre=@nombre, telefono=@telefono WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = r.Id },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = r.Nombre },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = r.Nombre },
            };


            Console.WriteLine("Modificado con éxito");
            bool encontrado = con.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean DeleteResponsable(int id)
        {
            string sql = "DELETE Responsable WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };

            Console.WriteLine("Eliminado con éxito");
            bool encontrado = con.Consulta(sql, parametros);
        
            return encontrado;
        }

        public static Responsable GetResponsable(int id)
        {

            string sql = "SELECT * FROM Responsable WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };

            Console.WriteLine("Conseguido con éxito");
            DataSet data = con.Seleccion(sql, parametros);
            DataRow row = data.Tables[0].Rows[0];
            return new Responsable(Convert.ToInt32(row["id"]), row["nombre"].ToString(), row["telefono"].ToString());
        }
    }
}
