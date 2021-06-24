using System.Collections.Generic;

namespace ConsoleArboles
{
    internal class Provincia
    {
        public string Nombre { get; set; }
        public List<Canton> Cantones { get; internal set; }

        internal int ObtenerHabitantes()
        {
            return new Random().(Next(); //Todoo Jeniffer terminar codigo
        }
    }
}