namespace obligatorio.clases
{
    public abstract class Persona
    {
        private int id;
        private string nombre;
        private string tipo;
        private string telefono;
        private string mail;

        public Persona(int id, string nombre, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
        }
        public Persona() { }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }

    }
}
