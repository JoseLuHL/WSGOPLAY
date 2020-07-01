using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class EstadoCancha
    {
        //public EstadoCancha()
        //{
        //    Reserva = null;
        //}

        public int Id { get; set; }
        public string Descripcion { get; set; }
        private ICollection<Reserva> reserva;

        public ICollection<Reserva> Reserva
        {
            get { return null; }
            set { reserva = value; }
        }

        //public virtual ICollection<Reserva> Reserva { get; set; } = null;
    }
}
