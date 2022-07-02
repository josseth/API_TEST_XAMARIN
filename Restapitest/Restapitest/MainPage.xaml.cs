using Newtonsoft.Json;
using Restapitest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Restapitest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cargalistaCarreras();
        }
        private async void cargalistaCarreras()
        {
            var InternetAccess = Connectivity.NetworkAccess;
            if (InternetAccess == NetworkAccess.Internet)
            {
                List<Models.Carrera> listaCarreras = new List<Models.Carrera>();
                listaCarreras = await Controllers.CarrerasController.getCarreras();

                List<int> tempcar = new List<int>();
                foreach (Carrera reg in listaCarreras)
                {
                    tempcar.Add(reg.id);
                }
                idCarr.ItemsSource = tempcar;
            }
            
        }
        private async void btncrear_Clicked(object sender, EventArgs e)
        {
            var alumn = new Alumno
            {
                nombre = txtnombre.Text,
                apellidos = txtape.Text,
                edad = Convert.ToInt32(txtedad.Text),
                direccion = txtdireccion.Text,
                genero=txtgenero.SelectedItem.ToString(),
                idCarrera= Convert.ToInt32(txtedad.Text),
            };
            await Controllers.Alumnos_Controllers.CrearAlumno(alumn);
            await Navigation.PopAsync();
        }
    }
        
}
