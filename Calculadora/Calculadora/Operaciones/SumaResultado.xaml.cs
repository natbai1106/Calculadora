using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SumaResultado : ContentPage
    {
        public SumaResultado(String r)
        {
            InitializeComponent();
            sumar.Text = "El resultado de la Suma es: " + r;
        }
    }
}