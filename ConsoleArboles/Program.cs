using System;
using System.Collections.Generic;

namespace ConsoleArboles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pais = new Pais
            {
                Nombre = "Ecuador",
                Descripcion = "Pais mas feliz del Mundo"
            };
            pais.Provincias.Add(new Provincia {Nombre = "Pichincha" });
            pais.Provincias.Add
                (
                    new Provincia

                {
                    Nombre = "Loja",
                    Cantones = new List<Canton>
                    {
                        new Canton
                        {
                            Nombre = "Loja",
                            Parroquias = new List<Parroquia>
                            {
                                new Parroquia
                                {
                                    Nombre = "Parroquia1",
                                    Habitantes = "15000"
                                },
                                new Parroquia
                                {
                                    Nombre = "Parroquia2",
                                    Habitantes = "12000"
                                }
                            }

               Console.WriteLine($
               Console.WriteLine(pais.ObtenerHabitantes());
        internal int ObtenerHabitantes()
        {
            var totalHabitantes = 0;
            foreach (Provincia actual in Provincias)
            {
                var habitantes = actual.ObtenerHabitantes();
                totalHabitantes = totalHabitantes+habitantes;

            }
            return totalHabitantes;
        }
    }
}

