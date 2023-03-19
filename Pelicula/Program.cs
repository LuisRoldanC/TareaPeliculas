using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
    
        //Campos
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;

    public Pelicula (string titulo, Int16 año){
        this.titulo = titulo;
        this.año = año;
}
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
          //  Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
        Pelicula p1 = new Pelicula("Titanic", 1997);
        p1.Imprime();

        Pelicula p2 = new Pelicula("Pinocho", 2022);
        p2.Imprime();
        }
    }
}
