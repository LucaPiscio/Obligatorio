namespace obligatorio.clases
{
    public class Local
    {
        private int idLocal;
        private string nombre;
        private string ciudad;
        private string direccion;
        private string telefono;
        private Responsable idRespon;

        #region Metodos

        public int IdLocal { get => idLocal; set => idLocal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public Responsable IdRespon { get => idRespon; set => idRespon = value; }

        #endregion

        public Local(int idLocal, string nombre, string ciudad, string direccion,string telefono, Responsable idRespon)
        {

            this.idLocal = idLocal;
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idRespon = idRespon;
        }
    
    }
}
