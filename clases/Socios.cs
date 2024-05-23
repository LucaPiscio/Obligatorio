using System.Runtime.CompilerServices;

namespace obligatorio.clases
{
    public class Socios 
    {
        private int id;
        private string nombre;
        private string tipo;
        private string telefono;
        private string mail;
        private Local idLocal;

        #region Metodos
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
        public Local IdLocal { get => idLocal; set => idLocal = value; }
        #endregion

        public Socios(int id,string nombre,string tipo,string telefono,string mail,Local idLocal)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.telefono = telefono;
            this.mail = mail;
            this.idLocal = idLocal;
        }
    }
}
