using obligatorio.clases;
using System.Data.SqlClient;
using System.Data;

    namespace obligatorio.persistencia
    {
        public class PLocal
        {
            private static Conexion conexion = new Conexion();

            public static Boolean Addlocal(Local m)
            {
                string sql = "INSERT INTO local (idLocal, name, city, phone, idRespon) VALUES (@id, @nombre, @tipo, @id)";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = m.IdLocal },
                new SqlParameter("@name", SqlDbType.VarChar) { Value = m.Name },
                new SqlParameter("@city", SqlDbType.VarChar) { Value = m.City },
                new SqlParameter("@phone", SqlDbType.VarChar) { Value = m.Phone },
                new SqlParameter("@idRespon", SqlDbType.VarChar) { Value = m.IdRespon },
            };


                Console.WriteLine("Ingresado con éxito");
                bool encontrado = conexion.Consulta(sql, parametros);
                return encontrado;
            }

            public static Boolean Updatelocal(Local m)
            {
                string sql = "UPDATE local SET nombre=@nombre, tipo=@tipo WHERE id=@id";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = m.IdLocal },
                new SqlParameter("@name", SqlDbType.VarChar) { Value = m.Name },
                new SqlParameter("@city", SqlDbType.VarChar) { Value = m.City },
                new SqlParameter("@phone", SqlDbType.VarChar) { Value = m.Phone },
                new SqlParameter("@idRespon", SqlDbType.VarChar) { Value = m.IdRespon },
            };


                Console.WriteLine("Modificado con éxito");
                bool encontrado = conexion.Consulta(sql, parametros);
                return encontrado;
            }

            public static Boolean Deletelocal(int id)
            {
                string sql = "DELETE Local WHERE idLocal=@idLocal";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = id }
            };

                Console.WriteLine("Eliminado con éxito");
                bool encontrado = conexion.Consulta(sql, parametros);
                return encontrado;
            }

            public static Local Getlocal(int id)
            {
                string sql = "SELECT * FROM Local WHERE idLocal=@idLocal";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = id }
            };

                Console.WriteLine("Conseguido con éxito");
                DataSet data = conexion.Seleccion(sql, parametros);
                DataRow row = data.Tables[0].Rows[0];
                return new Local(Convert.ToInt32(row["idLocal"]), row["name"].ToString(), row["city"].ToString(), row["phone"].ToString(), PResponsable.GetResponsable(Convert.ToInt32(row["id"])));
        }

            public static List<Locales>  Getlocales()
            {
            string sql = "SELECT * FROM Local";

            Console.WriteLine("Conseguidos con éxito");
            DataSet data = conexion.Seleccion(sql);
            List<Locales>
                locales = new List<Locales>
                    ();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                locales.Add(new Local(PLocal.Getlocal(Convert.ToInt32(row["idLocal"]), row["name"].ToString(), row["city"].ToString(), row["phone"].ToString(), PResponsable.GetResponsable(Convert.ToInt32(row["id"])));
            }
            return Locales;
            }
        }
    }
