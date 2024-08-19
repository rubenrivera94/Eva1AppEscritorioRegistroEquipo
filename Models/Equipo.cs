using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1AppRegistroEquipoFootball.Models
{
    public class Equipo
    {
        // Propiedades
        public string NombreEquipo { get; set; } = string.Empty;
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; } = string.Empty;
        public string TipoEquipo { get; set; } = string.Empty;
        public string CapitanEquipo { get; set; } = string.Empty;
        public bool TieneSub21 { get; set; } = false;

        // Constructor vacío
        public Equipo() { }

        // Constructor con todas las propiedades
        public Equipo(string nombreEquipo, int cantidadJugadores, string nombreDT, string tipoEquipo, string capitanEquipo, bool tieneSub21)
        {
            NombreEquipo = nombreEquipo;
            CantidadJugadores = cantidadJugadores;
            NombreDT = nombreDT;
            TipoEquipo = tipoEquipo;
            CapitanEquipo = capitanEquipo;
            TieneSub21 = tieneSub21;
        }
    }
}
