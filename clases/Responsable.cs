namespace obligatorio.clases
{
    public class Responsable 
    {
        private int idRespon;
        private string nombre;
        private string telefono;

        #region Metodos

        public int IdRespon { get => idRespon; set => idRespon = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        #endregion

        public Responsable(int idRespon, string nombre, string telefono)
        {
            this.idRespon = idRespon;
            this.nombre = nombre;
            this.telefono = telefono;
        }

    }
}
