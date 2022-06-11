﻿using System;
using System.Collections.Generic;

namespace CasaDeApuesas.Models
{
    public partial class Partido
    {
        public Partido()
        {
            Apuesta = new HashSet<Apuesta>();
        }

        public int Id { get; set; }
        public int? EquipoLocId { get; set; }
        public int? EquipoVisId { get; set; }
        public int? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual Equipos? EquipoLoc { get; set; }
        public virtual Equipos? EquipoVis { get; set; }
        public virtual ICollection<Apuesta> Apuesta { get; set; }
    }
}
