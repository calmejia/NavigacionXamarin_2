using System.Windows.Input;
using Xamarin.Forms_NavigationService.Services.Navigation;
using Xamarin.Forms_NavigationService.ViewModels.Base;

namespace Xamarin.Forms_NavigationService.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private string _parameter;

        private readonly INavigationService _navigationService;

        private DelegateCommand _backCommand;

        public SecondViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public string Parameter
        {
            get { return _parameter; }
            set
            {
                _parameter = value;
                RaisePropertyChanged();
            }
        }

        public ICommand BackCommand
        {
            get { return _backCommand = _backCommand ?? new DelegateCommand(BackCommandExecute); }
        }

        private void BackCommandExecute()
        {
            _navigationService.NavigateBack();
        }

        public override void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            if (navigationContext != null)
            {
                Parameter = navigationContext.ToString();
            }
        }
    }
}