using System;
using System.Collections.Generic;

namespace ArbolNodo
{
    class Program
    {
        static void Main(string[] args)
        {
            new Nodo()
            {
                Valor = "-",
                Izquierdo = new Nodo("5"),
                Derecho = new Nodo("3")
            };

            var raiz = new Nodo
            {
                Valor = "*",

                Izquierdo = new Nodo()
                {
                    Valor = "+",
                    Izquierdo = new Nodo("5"),
                    Derecho = new Nodo("3")
                }
            };
            Console.WriteLine(raiz.Izquierdo.Valor);
            raiz.Derecho = new Nodo()
            {
                Valor = "+",
                Izquierdo = new Nodo()
                {
                    Valor = "7"
                },
                Derecho = new Nodo()
                {
                    Valor = "4"
                }
            };
            raiz.Resultado = new Nodo()
            {
                Valor = "=",
                Izquierdo = new Nodo()
                {
                    Valor = "",
                },
                Derecho = new Nodo()
                {
                    Valor = ""
                }
            };
        }
    }
}
