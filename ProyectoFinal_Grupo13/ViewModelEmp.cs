using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls;

namespace ProyectoFinal_Grupo13
{
   public class ViewModelEmp : Empleado
    {
        public Image Img;
        public ContentControl CCImg;
        public ViewModelEmp(Empleado emp) 
        {
            Id = emp.Id;
            Nombre = emp.Nombre;
            Imagen = emp.Imagen;
            Salario = emp.Salario;
            Libres = emp.Libres;

            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + emp.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
        }

    }
}
