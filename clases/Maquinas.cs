using static System.Runtime.InteropServices.JavaScript.JSType;

namespace obligatorio.clases
{
    public class Maquinas
    {
        private int Id;
        private DateTime fechacom;
        private double precio;
        private DateTime vidautil;
        private string tipo;
        private string disponibilidad;
        private Local idLocal;


        #region Metodos
        public int Id1 { get => Id; set => Id = value; }
        public DateTime Fechacom { get => fechacom; set => fechacom = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime Vidautil { get => vidautil; set => vidautil = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public Local IdLocal { get => idLocal; set => idLocal = value; }

        #endregion



        public Maquinas(int id, DateTime fechacom, double precio, DateTime vidautil, string tipo, string disponibilidad, Local idLocal)
        {
            this.Id = id;
            this.fechacom = fechacom;
            this.precio = precio;
            this.vidautil = vidautil;
            this.tipo = tipo;
            this.disponibilidad = disponibilidad;
            this.idLocal = idLocal;
        }

    }
}
