using System;
using System.Collections.Generic;

namespace CasaDeApuesas.Models
{
    public partial class Apuesta
    {
        public int Id { get; set; }
        public int? PartidoId { get; set; }
        public int? EquipoId { get; set; }
        public int? UsuarioId { get; set; }
        public int? ModalidadId { get; set; }
        public string? Detalle { get; set; }
        public decimal? Monto { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaApuesta { get; set; }

        public virtual Equipos? Equipo { get; set; }
        public virtual ModalidadPago? Modalidad { get; set; }
        public virtual Partido? Partido { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
