using System.Collections.Generic;

namespace ConsoleArboles
{
    class Canton
    {
        public string Nombre { get; set; }
        public List<Parroquia> Parroquias { get; internal set; }
    }
}
