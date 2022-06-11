using System;
using System.Collections.Generic;

namespace CasaDeApuesas.Models
{
    public partial class ModalidadPago
    {
        public ModalidadPago()
        {
            Apuesta = new HashSet<Apuesta>();
        }

        public int Id { get; set; }
        public string? Detalle { get; set; }

        public virtual ICollection<Apuesta> Apuesta { get; set; }
    }
}
