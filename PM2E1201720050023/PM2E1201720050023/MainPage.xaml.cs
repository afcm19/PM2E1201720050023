using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;
using Xamarin.Essentials;

namespace PM2E1201720050023
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void buttomSalvar(object sender, EventArgs e)
        {

            if (!double.TryParse(tLatitud.Text, out double lat))
                return;

            if (!double.TryParse(tLongitud.Text, out double lng))
                return;

            if (DesUbicacion.Text == "")
            {
                await DisplayAlert("Esta es una Alerta", "Debe llenar la Descripcion", "Ok");
                return;
            }

            if (NUbicacion.Text == "")
            {
                await DisplayAlert(" Esta es unaAlerta", "Debe llenar Ubicacion", "Ok");
                return;
            }

            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = NUbicacion.Text,
                NavigationMode = NavigationMode.None

            });
        }

        private void buttomSalvadas_Clicked(object sender, EventArgs e)
        {

        }

        private void GPS_Clicked(object sender, EventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DisplayAlert("GPS desactivado", "", "Ok");
                return;
            }
             else
            {
                DisplayAlert("GPS Activado", "Cuenta con Internet", "Ok");
            }

        }
    }
}


