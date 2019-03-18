using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListaTopGalatica
{
    public partial class ListView_Page : ContentPage
    {
        public ListView_Page(List<string> lista)
        {
            InitializeComponent();
            lista_de_dados.ItemsSource = lista;
        }
    }
}
