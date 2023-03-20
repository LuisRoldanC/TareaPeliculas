using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
    //Campos
        private string titulo { get; set; }
        private int año { get; set; }
       // private string pais;
      //  private string director;

     private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(string titulo, int año){
        this.titulo = titulo;
        this.año = año;
}
         //Métodos
         public void AgregarActor(Actor actor){
            actores.Add(actor);
            }
        public void ImprimeActores(){
            foreach (Actor a in actores)
            {
                Console.WriteLine(a);
            }
        }

  /*  public Pelicula (string titulo, Int16 año, string pais, string director){
        this.titulo = titulo;
        this.año = año;
        this.pais = pais;
        this.director = director;
}*/

       /* public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void SetAño(Int16 año)
        {
            this.año = año;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }
        public Int16 GetAño()
        {
            return año;
        }
        public Int16 Año {
            get { return año; }
            set { año = value; }
        }
        public Pelicula(string t, Int16 a){
            titulo = t;
            año = a;
        }
        public Pelicula(){
        }
            public void Imprime()
        {
        Console.WriteLine($"{titulo} ({año})");
        }
    }*/



    public class Actor
    {
        //Campos
        private string nombre { get; set; }
        private Int16 año { get; set; }
        //Propiedades

        //Constructores
        public Actor(string nombre, Int16 año){
        this.nombre = nombre;
        this.año = año;
        }
        public override string ToString()
        {
            return $"{nombre} ({año})";
        }
        //Métodos 
        public void Imprime()
        {
          // Console.WriteLine($"{Nombre} ({Año})");
        }
    }
    

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {
        static void Main(string[] args)
        {
        Pelicula p1 = new Pelicula("La La Land", 2016);
        p1.AgregarActor(new Actor("Ryan Gosling", 1980));
        p1.AgregarActor(new Actor("Emma Stone", 1988));

        p1.ImprimeActores();
     /*  List<Pelicula> peliculas = new List<Pelicula>();

        peliculas.Add(new Pelicula () {Titulo = "Titanic", Año = 1997});
        peliculas.Add(new Pelicula () {Titulo = "Pinocho", Año = 2022});
        peliculas.Add(new Pelicula () {Titulo = "Rapidos y furiosos 10", Año = 2023});   
        peliculas.Add(new Pelicula () {Titulo = "Top Gun Maverick", Año = 2021});
        peliculas.Add(new Pelicula () {Titulo = "El Rey Leon", Año = 2020});

        foreach (Pelicula p in peliculas)
        {
            Console.WriteLine("{0} ({1})", p.Titulo, p.Año);
        }*/

        /*
        Pelicula p1 = new Pelicula();
        p1.SetTitulo("Titanic");
        p1.SetAño(1997);
        Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

        Pelicula p2 = new Pelicula();
        p2.SetTitulo("Pinocho");
        p2.SetAño(2022);
        Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño());
       */
        }
    }
    }
}
