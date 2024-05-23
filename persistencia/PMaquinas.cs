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
            string sql = "INSERT INTO Maquinas (id, fechacom,precio,vidautil,tipo,disponibilidad,idLocal) VALUES (@id, @fechacom,@precio,@vidautil,@tipo,@disponibilidad, @idLocal)";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = m.Id1 },
                new SqlParameter("@fecha", SqlDbType.VarChar) { Value = m.Fechacom},
                new SqlParameter("@precio", SqlDbType.VarChar) { Value = m.Precio},
                new SqlParameter("@vidautil", SqlDbType.VarChar) { Value = m.Vidautil},
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = m.Tipo },
                new SqlParameter("@disponibilidad", SqlDbType.VarChar) { Value = m.Disponibilidad},
                new SqlParameter("@idLocal", SqlDbType.VarChar) { Value = m.IdLocal } ,
            };


            Console.WriteLine("Ingresado con éxito");
            bool encontrado = conexion.Consulta(sql, parametros);
            return encontrado;
        }

        public static Boolean UpdateMaquinas(Maquinas m)
        {
            string sql = "UPDATE Maquinas SET fechacom=@fechacom,precio=@precio,vidautil=@vidautil, tipo=@tipo,disponibilidad=@disponibilidad WHERE id=@id";

            SqlParameter[] parametros = {
                new SqlParameter("@id", SqlDbType.Int) { Value = m.Id1 },
                new SqlParameter("@fechacom", SqlDbType.VarChar) { Value = m.Fechacom},
                new SqlParameter("@precio", SqlDbType.VarChar) { Value = m.Precio},
                new SqlParameter("@vidautil", SqlDbType.VarChar) { Value = m.Vidautil},
                new SqlParameter("@tipo", SqlDbType.VarChar) { Value = m.Tipo },
                new SqlParameter("@disponibilidad", SqlDbType.VarChar) { Value = m.Disponibilidad},
                new SqlParameter("@idLocal", SqlDbType.VarChar) { Value = m.IdLocal } ,
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
            return new Maquinas(Convert.ToInt32(row["id"]),Convert.ToDateTime(row["fechacom"]), Convert.ToDouble(row["precio"]), Convert.ToDateTime(row["vidautil"]), row["tipo"].ToString(), row["disponibilidad"].ToString(), PLocal.Getlocal(Convert.ToInt32(row["idLocal"])));
        }
        public static List<Maquinas> GetMaquinas()
        {
            string sql = "SELECT * FROM Maquina";

            Console.WriteLine("Conseguido con éxito");
            DataSet data = conexion.Seleccion(sql);
            List<Maquinas> maquina = new List<Maquinas>();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                maquina.Add(new Maquinas(Convert.ToInt32(row["id"]),Convert.ToDateTime( row["fechacom"]), Convert.ToDouble(row["precio"]), Convert.ToDateTime(row["vidautil"]), row["tipo"].ToString(), row["disponibilidad"].ToString(), PLocal.Getlocal(Convert.ToInt32(row["idLocal"]))));
            }
            return maquina;
        }
    }
}
