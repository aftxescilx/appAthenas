using athenas.Models;
using athenas.ViewModels;
using Xamarin.Forms;

namespace athenas.Views
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