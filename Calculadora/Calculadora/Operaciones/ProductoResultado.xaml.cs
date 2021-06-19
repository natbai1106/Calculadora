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
    public partial class ProductoResultado : ContentPage
    {
        public ProductoResultado(String r)
        {
            InitializeComponent();
            producto.Text = "El resultado de la Multiplicación es: " + r;
        }
    }
}