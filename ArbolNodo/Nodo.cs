using System;

namespace ArbolNodo
{
    class Nodo
    {
        private string _valor;
        public Nodo() { }
        public Nodo(string valor)
        {
            Console.WriteLine("Estoy en el constructor");
            Valor = valor;
        }

        public string Valor { get{ return _valor; } set {
                Console.WriteLine("Estoy en la propiedad");
                _valor = value;} }

        public string ResultadoNodos = "";
        public void OperacionNodo(Nodo nodo)
        {
            if (nodo == null)
                return;
            OperacionNodo(nodo.Izquierdo);
            ResultadoNodos += nodo.Valor;
            OperacionNodo(nodo.Derecho);
        }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public string V { get; }
        public Nodo Resultado { get; internal set; }
    }
}
