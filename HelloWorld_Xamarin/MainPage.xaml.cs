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
        /// <summary>
        /// evento asociado al click del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Clicked(object sender, EventArgs e)
            //async y await sirve para que no se quede el hilo de aplicacion colgado
        {
            #region declaracionVariables
            //coge el txt que escriba el usuario txtNombre esta declarado en MainPage.xaml
            clsPersona user = new clsPersona(txtNombre.Text);
            #endregion 
            await DisplayAlert ("Mensaje", $"Hola { user.Nombre}  saludos", "OK");
        }
    }
}
