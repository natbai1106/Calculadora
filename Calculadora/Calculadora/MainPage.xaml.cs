using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage

    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void suma_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Hay campo vacio", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 + n2;
                await Navigation.PushAsync(new SumaResultado(resul.ToString()));
            }
        }

        private async void resta_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Hay campo vacio", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 - n2;
                await Navigation.PushAsync(new RestaResultado(resul.ToString()));
            }
        }

        private async void producto_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Hay campo vacio", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 * n2;
                await Navigation.PushAsync(new ProductoResultado(resul.ToString()));
            }
        }

        private async void division_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(num1.Text) || (String.IsNullOrWhiteSpace(num2.Text)))
            {
                await this.DisplayAlert("Error", "Hay campo vacio", "Ok");
            }
            else
            {
                int n1 = Convert.ToInt32(num1.Text);
                int n2 = Convert.ToInt32(num2.Text);
                int resul = n1 / n2;
                await Navigation.PushAsync(new DivisionResultado(resul.ToString()));
            }
        }

        private void limpiar_Clicked(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
        }
    }
}