using Lab07.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab07.Views
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