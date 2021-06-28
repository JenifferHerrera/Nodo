using System;

namespace Arbol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea Arboles!");
            #region EjemploClase
            Nodo raiz = new Nodo()
            {
                Valor = "*",
                Hijos =
                {
                new Nodo
                {
                    Valor = "+",
                    Hijos =
                    {
                        new Nodo
                        {
                            Valor = "5"
                        },
                        new Nodo
                        {
                            Valor = "4"
                        }
                    }
                },
                new Nodo
                {
                    Valor = "-",
                    Hijos =
                    {
                        new Nodo
                        {
                            Valor = "8"
                        },
                        new Nodo
                        {
                            Valor = "3"
                        }
                    }
                }
            }
        };
            // Resultado de
            // => (5 + 4) * (8 - 3) = 45 notacion infija
            // => *(+ 5  4) (-8  3) = 45 notacion prefija
            // => (5  4 +) (8  3 -)* = 45 primero operando y despues operaciones-visceversa

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPostfijo(raiz));
            #region 

            var raiz1 = new Nodo 
            {
                Valor = "Padre",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "Luis",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor = "Maria"
                            },
                            new Nodo
                            {
                                Valor = "Marlon",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor = "Antonio"
                                    },
                                    new Nodo
                                    {
                                        Valor = "Luisa"
                                    },
                                    new Nodo
                                    {
                                        Valor = "Luciano",
                                        Hijos =
                                        {
                                            new Nodo
                                            {
                                                Valor = "Manuela"
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Console.WriteLine($"Numero de hojas: {manejadorArbol.NumeroHojas(raiz1)}");
            Console.WriteLine($"Numero de nodos: {manejadorArbol.NumeroNodos(raiz1)}");
            Console.WriteLine($"Numero de niveles: {manejadorArbol.NumeroNiveles(raiz1)}");
        }
    }
}
