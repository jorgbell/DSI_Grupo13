using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;


// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoFinal_Grupo13
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Contrataciones : Page
    {
        public ObservableCollection<VMDron>  ListaEmpleados { get; } = new ObservableCollection<VMDron>();
        public int a; //maybe hacer un array con todos los id de los que tienes seleccionados?
        public Contrataciones()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaEmpleados != null)
                foreach (Dron emp in Model.GetAllDrones())
                {
                    VMDron VMitem = new VMDron(emp);
                    ListaEmpleados.Add(VMitem);
                }
            base.OnNavigatedTo(e);
            
        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMDron Item = e.ClickedItem as VMDron;
            //Imagen.Source = Item.Img.Source;
            //Texto.Text = Item.Explicacion;
            //ImagenC.Source = Item.Img.Source;
            a = Item.Id; //Solo te guarda el ultimo pulsado, no se como borrar los que deseleccionas
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ListaEmpleados.RemoveAt(a); Al volver a la página la lista se llena de nuevo
            foreach (VMDron item in itemListView.SelectedItems)
            {
                Model.Contratados.Add(item);
                Model.Drones.RemoveAt(item.Id);
            }

            this.Frame.Navigate(typeof(Map), a);
        }
    }
}
