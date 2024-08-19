using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1AppRegistroEquipoFootball.Models
{
    // Declaramos la clase como estática para que no sea necesario crear una instancia de EquipoData para acceder a la lista Equipos.
    // Esto permite acceder a la lista de equipos directamente mediante la clase EquipoData.
    internal static class EquipoData
    {
        // Lista estática para almacenar los equipos.
        // La propiedad 'Equipos' es pública y tiene un getter y un setter para permitir acceso y modificación desde otras partes del código.
        // La lista se inicializa como una nueva instancia de List<Equipo>().
        public static List<Equipo> Equipos { get; set; } = new List<Equipo>();
    }
}