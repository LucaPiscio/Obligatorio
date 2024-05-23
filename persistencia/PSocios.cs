using System.Data.SqlClient;
using System.Data;
using obligatorio.clases;

namespace obligatorio.persistencia
{
    public class PSocios
    {
        private static Conexion conexion = new Conexion();

        public static Boolean AddSocios(Socios p)
        {
            string sql = "INSERT INTO Socio (id, nombre, tipo, telefono, mail,idLocal) VALUES (@id, @nombre, @tipo,@telefono,@mail @idLocal)";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = p.Id },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = p.Nombre },
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = p.Tipo },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = p.Telefono },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = p.Mail },
                new SqlParameter("@idLocal", SqlDbType.VarChar) { Value = p.IdLocal } ,
            };


            Console.WriteLine("Ingresado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean UpdateSocios(Socios p)
        {
            string sql = "UPDATE Socios SET nombre=@nombre, tipo=@tipo, telefono=@telefono, mail=@mail, idLocal=@idLocal WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = p.Id },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = p.Nombre },
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = p.Tipo },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = p.Telefono },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = p.Mail },
                new SqlParameter("@idLocal", SqlDbType.VarChar) { Value = p.IdLocal } ,
            };


            Console.WriteLine("Modificado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean DeleteSocios(int id)
        {
            string sql = "DELETE Socios WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };

            Console.WriteLine("Eliminado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Socios GetSocios(int id)
        {
            // Cambié Socio por Socios (nombre de la tabla)
            string sql = "SELECT * FROM Socios WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = id }
            };

            Console.WriteLine("Conseguido con éxito");
            DataSet data = conexion.Seleccion(sql, parametros);
            DataRow row = data.Tables[0].Rows[0];

            return new Socios(Convert.ToInt32(row["id"]), row["nombre"].ToString(), row["tipo"].ToString(), row["telefono"].ToString(), row["mail"].ToString(), PLocal.Getlocal(Convert.ToInt32(row["idLocal"])));
        }
        public static List<Socios> GetSocios()
        {
            string sql = "SELECT * FROM Socio";

            Console.WriteLine("Conseguido con éxito");
            DataSet data = conexion.Seleccion(sql);
            List<Socios> personas = new List<Socios>();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                personas.Add(new Socios(Convert.ToInt32(row["id"]), row["nombre"].ToString(), row["tipo"].ToString(), row["telefono"].ToString(), row["mail"].ToString(), PLocal.Getlocal(Convert.ToInt32(row["idLocal"]))));
           }
            return personas;
        }
    }
}

