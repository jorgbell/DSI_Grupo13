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
        public string Explicacion { get; set; }
        public estados Estado { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int RX;
        public int RY;



        public Dron() { }
    }
    public class Model
    {
        public static List<Dron> Drones = new List<Dron>()
        {                       
            new Dron()
            {
                Id = 0,
                Nombre = "Feliz",
                Imagen = "Assets\\Samples\\1.jpg",
                Explicacion = @"Explicación Dron1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 10,
                Y = 10,
                RX =100,
                RY =30,
             },
            new Dron()
            {
                Id = 1,
                Nombre = "Enfadado",
                Imagen = "Assets\\Samples\\2.jpg",
                Explicacion = @"Explicación Dron2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 50,
                Y = 50,
                RX =150,
                RY =50,
             },
            new Dron()
            {
                Id = 2,
                Nombre = "Triste",
                Imagen = "Assets\\Samples\\3.jpg",
                Explicacion = @"Explicación Dron3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 100,
                Y = 100,
                RX =50,
                RY =130,
             },
            new Dron()
            {
                Id = 3,
                Nombre = "Normal",
                Imagen = "Assets\\Samples\\4.jpg",
                Explicacion = @"Explicación Dron4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 150,
                Y = 150,
                RX =200,
                RY =80,
             },
            new Dron()
            {
                Id = 4,
                Nombre = "Feliz",
                Imagen = "Assets\\Samples\\5.jpg",
                Explicacion = @"Explicación Dron5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 200,
                Y = 200,
                RX =100,
                RY =140,
             },
            new Dron()
            {
                Id = 5,
                Nombre = "Encantado",
                Imagen = "Assets\\Samples\\6.jpg",
                Explicacion = @"Explicación Dron6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
                X = 250,
                Y = 250,
                RX =30,
                RY =50,
             },
            new Dron()
            {
                Id = 6,
                Nombre = "Normal",
                Imagen = "Assets\\Samples\\7.jpg",
                Explicacion = @"Explicación Dron7 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Dron.estados.Aterrizado,
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

        public static Dron GetDronById(int id)
        {
            return Drones[id];
        }
    }
}
