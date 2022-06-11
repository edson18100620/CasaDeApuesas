using System;
using System.Collections.Generic;

namespace CasaDeApuesas.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Equipos = new HashSet<Equipos>();
            Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
