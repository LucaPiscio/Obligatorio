namespace obligatorio.clases
{
    public class Local
    {
        private int idLocal;
        private string name;
        private string city;
        private string phone;
        private Responsable idRespon;

        #region Metodos

        public int IdLocal { get => idLocal; set => idLocal = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Phone { get => phone; set => phone = value; }
        public Responsable IdRespon { get => idRespon; set => idRespon = value; }

        #endregion

        public Local(int idLocal, string name, string city, string phone, Responsable idRespon)
        {

            this.idLocal = idLocal;
            this.name = name;
            this.city = city;
            this.phone = phone;
            this.idRespon = idRespon;
        }
    
    }
}
