﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProyectoFinal_Grupo13
{
    public class VMDron : Dron
    {
        public Image Img;
        public ContentControl CCImg;
        public int Zoom;
        public RotateTransform Rotacion;
        public int Angulo;
        public VMDron(Dron dron)
        {
            Id = dron.Id;
            Nombre = dron.Nombre;
            Imagen = dron.Imagen;
            Estado = dron.Estado;
            Salario = dron.Salario;
            Libres = dron.Libres;
            X = dron.X;
            Y = dron.Y;
            RX = dron.RX;
            RY = dron.RY;

            Angulo = 0;
            Rotacion = new RotateTransform();
            Rotacion.Angle = Angulo;
            Rotacion.CenterX = 25;
            Rotacion.CenterY = 25;


            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + dron.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
            CCImg.RenderTransform = Rotacion;
        }
    }



}

