using System;
using System.Collections.Generic;

namespace ConsoleArboles
{
    internal class Pais
    {
        public string Nombre { get; internal set; }
        public List<Provincia> Provincias { get; internal set; } = new List<Provincia>();
        public string Descripcion { get; internal set; }

        internal bool ObtenerHabitantes()
        {
            throw new NotImplementedException();
        }
    }
}