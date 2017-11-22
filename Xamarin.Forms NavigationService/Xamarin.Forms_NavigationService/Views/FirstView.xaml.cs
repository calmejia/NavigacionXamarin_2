using Xamarin.Forms;
using Xamarin.Forms_NavigationService.ViewModels;

namespace Xamarin.Forms_NavigationService.Views
{
    public partial class FirstView : ContentPage
    {
        private object Parameter { get; set; }

        public FirstView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = App.Locator.FirstViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as FirstViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as FirstViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
