using System;
using System.Collections.Generic;
using System.ComponentModel;
using Teste.Models;
using Teste.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teste.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}