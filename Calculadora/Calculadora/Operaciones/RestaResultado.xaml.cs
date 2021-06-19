﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaResultado : ContentPage
    {
        public RestaResultado(String r)
        {
            InitializeComponent();
            restar.Text = "El resultado de la Resta es: " + r;
        }
    }
}