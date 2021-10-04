using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace HelloWorld_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /**
         * 
         */
        private async void Button_Clicked(object sender, EventArgs e)
        {
            Entry entry = txtNombre;//nueva entrada que coja el txt que escriba el usuario txtNombre esta declarado en MainPage.xaml
            clsPersona persona1 = new clsPersona(entry.Text);
            await DisplayAlert ("Mensaje", "Hola "+persona1.Nombre+" saludos", "OK");
        }
    }
}
