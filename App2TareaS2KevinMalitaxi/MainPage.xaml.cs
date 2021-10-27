using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2TareaS2KevinMalitaxi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
           

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            String Usuario = txtUsuario.Text;
            String Clave = txtClave.Text;

            String user = "estudiante2021";
            String pass = "uisrael2021";


            try
            {
                if (Usuario == user && Clave == pass)
                {
                    await Navigation.PushAsync(new ventanaDos(Usuario, Clave));

                }
        
                else if (Clave != pass)
                {
                    DisplayAlert("ERROR DE INGRESO DE CREDENCIALES", "Usuario o Contraseña Incorrecta", "OK");
                }
                else if (Usuario != user)
                {
                    DisplayAlert("ERROR DE INGRESO DE CREDENCIALES", "Usuario o Contraseña Incorrecta", "OK");
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}
