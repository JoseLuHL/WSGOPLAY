using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class Horario
    {
        //public Horario()
        //{
        //    Reserva = new HashSet<Reserva>();
        //    Sinreserva = new HashSet<Sinreserva>();
        //}

        public int Id { get; set; }
        public string ProNombre { get; set; }
        public string ProPrecio { get; set; }
        public int? IdCancha { get; set; }

        public virtual WoPages IdCanchaNavigation { get; set; }
        //public virtual ICollection<Reserva> Reserva { get; set; }
        private  ICollection<Reserva> reserva;

        public virtual ICollection<Reserva> Reserva
        {
            get { return null; }
            set { reserva = value; }
        }

        public virtual ICollection<Sinreserva> Sinreserva { get; set; }
    }
}
