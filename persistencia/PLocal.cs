using obligatorio.clases;
using System.Data.SqlClient;
using System.Data;

    namespace obligatorio.persistencia
    {
        public class PLocal
        {
            private static Conexion conexion = new Conexion();

            public static Boolean Addlocal(Local l)
            {
                string sql = "INSERT INTO Local (idLocal, nombre, ciudad,direccion,telefono, idRespon) VALUES (@id, @nombre, @ciudad, @direcicon,@telefono,@idRespon)";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = l.IdLocal },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = l.Nombre },
                new SqlParameter("@ciudad", SqlDbType.VarChar) { Value = l.Ciudad },
                new SqlParameter("@direccion", SqlDbType.VarChar) { Value = l.Direccion },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = l.Telefono },
                new SqlParameter("@idRespon", SqlDbType.VarChar) { Value = l.IdRespon },
            };


                Console.WriteLine("Ingresado con éxito");
                bool encontrado = conexion.Consulta(sql, parametros);
                return encontrado;
            }

            public static Boolean Updatelocal(Local l)
            {
                string sql = "UPDATE Local SET nombre=@nombre, ciudad=@ciudad,direccion=@direccion,telefono=@telefono,idRespon=@idRespon WHERE idLocal=@idLocal";

                SqlParameter[] parametros = {
                new SqlParameter("@idLocal", SqlDbType.Int) { Value = l.IdLocal },
                new SqlParameter("@nombre", SqlDbType.VarChar) { Value = l.Nombre },
                new SqlParameter("@ciudad", SqlDbType.VarChar) { Value = l.Ciudad },
                new SqlParameter("@direccion", SqlDbType.VarChar) { Value = l.Direccion },
                new SqlParameter("@telefono", SqlDbType.VarChar) { Value = l.Telefono},
                new SqlParameter("@idRespon", SqlDbType.VarChar) { Value = l.IdRespon },
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
                return new Local(Convert.ToInt32(row["idLocal"]), row["nombre"].ToString(), row["ciudad"].ToString(), row["direccion"].ToString(), row["telefono"].ToString(), PResponsable.GetResponsable(Convert.ToInt32(row["id"])));
        }

            public static List<Local>  Getlocales()
            {
            string sql = "SELECT * FROM Local";

            Console.WriteLine("Conseguidos con éxito");
            DataSet data = conexion.Seleccion(sql);
            List<Local>
                locales = new List<Local>
                    ();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                locales.Add(new Local(Convert.ToInt32(row["idLocal"]), row["nombre"].ToString(), row["ciudad"].ToString(), row["direccion"].ToString(), row["telefono"].ToString(), PResponsable.GetResponsable(Convert.ToInt32(row["idRespon"]))));
            }
            return locales;
            }
        }
    }
