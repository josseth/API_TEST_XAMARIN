using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restapitest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageBooks : ContentPage
    {
        public PageBooks()
        {
            InitializeComponent();
        }
        private async void btnconsume_Clicked(object sender, EventArgs e)
        {
            var InternetAccess = Connectivity.NetworkAccess;
            if (InternetAccess == NetworkAccess.Internet) 
            {
                //List<Models.Books> listbook = new List<Models.Books>();
                //listbook = await Controllers.BookController.getBooks();
                //listaAlumnos.ItemsSource = listbook;

                List<Models.Alumno> listaAlumno = new List<Models.Alumno>();
                listaAlumno = await Controllers.Alumnos_Controllers.getAlumnos();
                listaAlumnos.ItemsSource = listaAlumno;
            }
        }

        private void listaAlumnos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private async void btnCrear_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}