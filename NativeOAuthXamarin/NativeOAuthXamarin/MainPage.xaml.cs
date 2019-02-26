using Xamarin.Forms;

namespace NativeOAuthXamarin
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel viewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
