using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo13
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Salario { get; set; }
        public string Libres { get; set; }

        public Empleado() {}
    }
    public class EmpleadoModel
    {
        public static List<Empleado> Empleados = new List<Empleado>
        {
            new Empleado(){
                Id = 0,
                Nombre = "Mengano",
                Imagen = "Assets\\Images\\1.jpg",
                Salario = "700$ / mes",
                Libres = "Lunes y Martes",
            },

            new Empleado(){
                Id = 1,
                Nombre = "Fulano",
                Imagen = "Assets\\Images\\2.jpg",
                Salario = "900$ / mes",
                Libres = "Domingos",
            },

            new Empleado(){
                Id = 2,
                Nombre = "Butano",
                Imagen = "Assets\\Images\\3.jpg",
                Salario = "500$ / mes",
                Libres = "Martes y Jueves",
            },

            new Empleado(){
                Id = 3,
                Nombre = "Gustavo",
                Imagen = "Assets\\Images\\4.jpg",
                Salario = "850$ / mes",
                Libres = "Miercoles",
            },

            new Empleado(){
                Id = 4,
                Nombre = "Arkano",
                Imagen = "Assets\\Images\\5.jpg",
                Salario = "700$ / mes",
                Libres = "Viernes y Sabado",
            },

        };
        public static IList<Empleado> GetEmpleados() { return Empleados; }

        public static Empleado GetEmpleadoById(int id) { return Empleados[id]; }
    }
}
