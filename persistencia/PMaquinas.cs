using System;
using System.Data.SqlClient;
using System.Data;
using obligatorio.clases;

namespace obligatorio.persistencia
{
    public class PMaquinas
    {
        private static Conexion conexion = new Conexion();

        public static Boolean AddMaquinas(Maquinas m)
        {
            string sql = "INSERT INTO Maquinas (id, nombre, tipo) VALUES (@id, @nombre, @tipo, @id)";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = m.Id1 },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = m.Nombre },
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = m.Tipo },
            };


            Console.WriteLine("Ingresado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean UpdateMaquinas(Maquinas m)
        {
            string sql = "UPDATE Maquinas SET nombre=@nombre, tipo=@tipo WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = m.Id1 },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = m.Nombre },
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = m.Tipo },
            };


            Console.WriteLine("Modificado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean DeleteMaquinas(int id)
        {
            string sql = "DELETE Maquinas WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };
       
            Console.WriteLine("Eliminado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Maquinas GetMaquinas(int id)
        {
            string sql = "SELECT * FROM Maquinas WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };

            Console.WriteLine("Conseguido con éxito");
            DataSet data = conexion.Seleccion(sql, parametros);
            DataRow row = data.Tables[0].Rows[0];
            return new Maquinas(Convert.ToInt32(row["id"]), row["nombre"].ToString(), row["tipo"].ToString());
        }
        //public static List<Socios> GetPersonas()
        //{
        //    string sql = "SELECT * FROM persona";

        //    Console.WriteLine("Conseguido con éxito");
        //    DataSet data = conexion.Seleccion(sql);
        //    List<Socios> personas = new List<Socios>();
        //    foreach (DataRow row in data.Tables[0].Rows)
        //    {
        //        personas.Add(new Socios(Convert.ToInt32(row["id"]), row["nombre"].ToString(), row["apellido"].ToString(), row["ci"].ToString(), new Local()));
        //    }
        //    return personas;
        //}
    }
}
