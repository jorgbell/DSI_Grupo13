using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo13
{
    public class Dron
    {
        public enum estados { Aterrizado, Autonomo, Manual };

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        //public Image Img;
        public string Estado { get; set; }
        public string Salario { get; set; }
        public string Libres { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int RX;
        public int RY;



        public Dron() { }
    }
    public class Model
    {

        public static List<Dron> Contratados = new List<Dron>() {};
        public static List<Dron> Drones = new List<Dron>()
        {
            new Dron()
            {
                Id = 0,
                Nombre = "Mengano",
                Imagen = "Assets\\Images\\1.jpg",
                Estado = "Feliz",
                Salario = "700$ / mes",
                Libres = "Lunes y Martes",
                X = 10,
                Y = 10,
                RX =100,
                RY =30,
             },
            new Dron()
            {
                Id = 1,
                Nombre = "Fulano",
                Imagen = "Assets\\Images\\2.jpg",
                Estado = "Enfadado",
                Salario = "900$ / mes",
                Libres = "Domingos",
                X = 50,
                Y = 50,
                RX =150,
                RY =50,
             },
            new Dron()
            {
                Id = 2,
                Nombre = "Butano",
                Imagen = "Assets\\Images\\3.jpg",
                Estado = "Triste",
                Salario = "700$ / mes",
                Libres = "Viernes y Sabado",
                X = 100,
                Y = 100,
                RX =50,
                RY =130,
             },
            new Dron()
            {
                Id = 3,
                Nombre = "Gustavo",
                Imagen = "Assets\\Images\\4.jpg",
                Estado = "Normal",
                Salario = "500$ / mes",
                Libres = "Martes y Jueves",
                X = 150,
                Y = 150,
                RX =200,
                RY =80,
             },
            new Dron()
            {
                Id = 4,
                Nombre = "Arkano",
                Imagen = "Assets\\Images\\5.jpg",
                Estado = "Feliz",
                Salario = "850$ / mes",
                Libres = "Miercoles",
                X = 200,
                Y = 200,
                RX =100,
                RY =140,
             },
            new Dron()
            {
                Id = 5,
                Nombre = "Afur",
                Imagen = "Assets\\Images\\6.jpg",
                Estado = "Encantado",
                Salario = "700$ / mes",
                Libres = "Viernes y Sabado",
                X = 250,
                Y = 250,
                RX =30,
                RY =50,
             },
            new Dron()
            {
                Id = 6,
                Nombre = "Steven",
                Imagen = "Assets\\Images\\7.jpg",
                Estado = "Normal",
                Salario = "600$ / mes",
                Libres = "Viernes",
                X = 300,
                Y = 300,
                RX =250,
                RY =200,
             },
          };


        public static IList<Dron> GetAllDrones()
        {
            return Drones;
        }

        public static IList<Dron> GetAllContratados()
        {
            return Contratados;
        }
        public static Dron GetDronById(int id)
        {
            return Drones[id];
        }

        public static void DronesRemoveItemWithId(int id)
        {
            int i = 0;
            while(i< Drones.Count() && Drones[i].Id != id) i++;
            Drones.RemoveAt(i);
        }
    }
}
