using BarleyBreak.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BarleyBreak.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
