using System.ComponentModel;
using Teste.ViewModels;
using Xamarin.Forms;

namespace Teste.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}