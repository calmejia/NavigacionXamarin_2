using Xamarin.Forms;
using Xamarin.Forms_NavigationService.ViewModels;

namespace Xamarin.Forms_NavigationService.Views
{
    public partial class SecondView : ContentPage
    {
        private object Parameter { get; set; }

        public SecondView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.SecondViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as SecondViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as SecondViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}