using System.Windows.Input;
using Xamarin.Forms_NavigationService.Services.Navigation;
using Xamarin.Forms_NavigationService.ViewModels.Base;

namespace Xamarin.Forms_NavigationService.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private DelegateCommand _navigateCommand;
        private DelegateCommand _parameterCommand;

        public FirstViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand NavigateCommand
        {
            get { return _navigateCommand = _navigateCommand ?? new DelegateCommand(NavigateCommandExecute); }
        }

        public ICommand ParameterCommand
        {
            get { return _parameterCommand = _parameterCommand ?? new DelegateCommand(ParameterCommandExecute); }
        }

        private void NavigateCommandExecute()
        {
            _navigationService.NavigateTo<SecondViewModel>();
        }

        private void ParameterCommandExecute()
        {
            _navigationService.NavigateTo<SecondViewModel>("Parámetro desde FirstViewModel");
        }
    }
}