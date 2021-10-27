using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2TareaS2KevinMalitaxi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ventanaDos : ContentPage
    {
        public ventanaDos(String usuario, String clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double Seg1 = Convert.ToDouble(txtValorUno.Text);
                double examen1 = Convert.ToDouble(txtValorDos.Text);

                double Seg2 = Convert.ToDouble(txtValorTres.Text);
                double examen2 = Convert.ToDouble(txtValorCuatro.Text);

                //Operaciones para Cálculo de Notas
                double parcial1 = (Seg1 * 0.3) + (examen1 * 0.2);
                double parcial2 = (Seg2 * 0.3) + (examen2 * 0.2);

                double final = parcial1 + parcial2;


                //Visualizacion del resultado en pantalla 
                txtResultado1.Text = parcial1.ToString();
                txtResultado2.Text = parcial2.ToString();
                txtFinal.Text = final.ToString();


                if (final >= 7)
                {
                    DisplayAlert("Resultado De Notas", "Felicidades el Estudiante se encuentra: APROBADO", "Salir");
                }
                else if (final >= 5 && final <= 6.99)
                {
                    DisplayAlert("Resultado De Notas", "El estudiante debe rendir el Examen COMPLEMENTARIO", "Salir");
                }
                else
                {
                    DisplayAlert("Resultado De Notas", "Lastimosamente el estudiante se encuentra: REPROBADO", "Salir");
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje De Alerta", ex.Message, "Salir");
            }

        }

        private void txtValorUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double valU = Convert.ToDouble(txtValorUno.Text);
                if (valU > 10)
                {
                    DisplayAlert("ERROR", "Cantidad digitada no debe ser mayor a 10", "OK");
                }
            }
            catch (Exception ex) 
            {
                DisplayAlert("ERROR", ex.Message, "OK");

            }
            }

        private void txtValorDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double valD = Convert.ToDouble(txtValorDos.Text);
                if (valD > 10)
                {
                    DisplayAlert("ERROR", "Cantidad digitada no debe ser mayor a 10", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "OK");

            }

        }

        private void txtValorTres_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double valT = Convert.ToDouble(txtValorTres.Text);
                if (valT > 10)
                {
                    DisplayAlert("ERROR", "Cantidad digitada no debe ser mayor a 10", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "OK");

            }

        }

        private void txtValorCuatro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double valC = Convert.ToDouble(txtValorCuatro.Text);
                if (valC > 10)
                {
                    DisplayAlert("ERROR", "Cantidad digitada no debe ser mayor a 10", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "OK");

            }


        }
    }
    }