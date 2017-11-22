using Microsoft.Practices.Unity;
using Xamarin.Forms_NavigationService.Services.Navigation;

namespace Xamarin.Forms_NavigationService.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            // ViewModels
            _container.RegisterType<FirstViewModel>();
            _container.RegisterType<SecondViewModel>();

            // Services     
            _container.RegisterType<INavigationService, NavigationService>();
        }

        public FirstViewModel FirstViewModel => _container.Resolve<FirstViewModel>();

        public SecondViewModel SecondViewModel => _container.Resolve<SecondViewModel>();
    }
}