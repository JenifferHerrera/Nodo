using System;
using System.Linq;

namespace Arbol2
{
    class ManejadorArbol
    {
        private int nivelActual;

        //Metodo recursiva se llama a si mismo "ImprimirArbolInfijo"
        public string ImprimirArbolInfijo(Nodo nodo)
        {
            //Comportamiento de la Hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            ///foreach (Nodo actual in nodo.Hijos)

            //Analiza cuando no es hoja 
            {
                return $"( {ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} { ImprimirArbolInfijo(nodo.Hijos[1])} )";
            }

            ///throw new NotImplementedException();
        }

        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            //Comportamiento de la Hoja 
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //Analiza cuando no es hoja
            return $"{nodo.Valor} ( {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo(nodo.Hijos[1])} )";
        }
        internal string ImprimirArbolPostfijo(Nodo nodo)
        {
            //Comportamiento de la Hoja 
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //Analiza cuando no es hoja
            return $"( {ImprimirArbolPostfijo(nodo.Hijos[0])} {ImprimirArbolPostfijo(nodo.Hijos[1])} ) {nodo.Valor} )";
            
        }

        internal int NumeroHojas(Nodo nodo)
        {
            //Identificar si soy hoja
            if (SoyHoja(nodo))
                return 1;

            int totalHojas = 0;
            foreach ( var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
               
            }
            return totalHojas;

            //var hojasHijo1 = NumeroHojas(nodo.Hijos[0]); 
            //var hojasHijo2 = NumeroHojas(nodo.Hijos[1]);
            //var hojasHijo3 = NumeroHojas(nodo.Hijos[2]);
            //var hojasHijo4 = NumeroHojas(nodo.Hijos[3]);
            //var hojasHijoFinal = NumeroHojas(nodo.Hijos[nodo.Hijos.Count - 1]); //n => lengt/count, cantidad de elementos totales

            //return hojasHijo1 + hojasHijo2 + hojasHijo3 + hojasHijo4 + hojasHijoFinal;

        }

        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }
            return totalNodos + 1;

        }
        internal int NumeroNiveles(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            var nivelHijos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                var nivelAactual = NumeroNiveles(nodoActual);
                if (nivelHijos < nivelActual)
                    nivelHijos = nivelActual;
            }
            return ++nivelHijos;
        }
        private bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();

        }
    }
}
