using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoFinal_Grupo13
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Driving : Page
    {
        int speed = 0;
        int acceleration = 2;
        int limit = 60;
        DispatcherTimer HeatTimer;
        DateTimeOffset startTime;
        DateTimeOffset lastTime;
        DateTimeOffset stopTime;
        int timesTicked = 1;
        int flameCounter = 0;
        int timesToTick = 2;
        public Driving()
        {
            this.InitializeComponent();
            this.NavigationCacheMode =
            Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            Vel.Focus(FocusState.Keyboard);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            HeatTimerSetup();
        }
        public void HeatTimerSetup()
        {
            HeatTimer = new DispatcherTimer();
            HeatTimer.Tick += HeatTimer_Ticks;
            HeatTimer.Interval = new TimeSpan(10000);
            startTime = DateTimeOffset.Now;
            lastTime = startTime;
            HeatTimer.Start();
        }
        void HeatTimer_Ticks(object sender, object e)
        {
            DateTimeOffset time = DateTimeOffset.Now;
            TimeSpan span = time - lastTime;
            lastTime = time;
            //Time since last tick should be very very close to Interval
            timesTicked++;
            if (timesTicked > timesToTick)
            {
                if (timesTicked % 3 == 0) 
                {
                  flameCounter++;
                  flame.Opacity -= 0.01;
                }
                timesTicked = 0;
                //stopTime = time;
                //HeatTimer.Stop();
                //span = stopTime - startTime;
            }

        }
        private void New_Game(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Map));
        }

        private void Close_App(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Map));
        }

        private void Pedal_Pressed(object sender, RoutedEventArgs e)
        {
            if (speed + acceleration <= limit) speed += acceleration;
            Vel.Text = "" + speed;
        }
    }
}
