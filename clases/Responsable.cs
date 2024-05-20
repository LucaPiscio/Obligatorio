namespace obligatorio.clases
{
    public class Responsable
    {
        private int id;
        private string nombre;
        private string telefono;



        #region Metodos

        public int Id{ get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        #endregion

        public Responsable(int id, string nombre, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
        }

    }
}
