using static System.Runtime.InteropServices.JavaScript.JSType;

namespace obligatorio.clases
{
    public class Maquinas
    {
        private int Id;
        private string nombre;
        private string tipo;
        private Local idLocal;




        #region Metodos
        public int Id1 { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public Local IdLocal { get => idLocal; set => idLocal = value; }

        #endregion
        public Maquinas(int id, string nombre, string tipo, Local idLocal)
        {
            this.Id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.idLocal = idLocal;
            this.idLocal= idLocal;
        }
    }
}
