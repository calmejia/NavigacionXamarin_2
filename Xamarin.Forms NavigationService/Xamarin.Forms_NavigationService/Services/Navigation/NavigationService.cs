using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms_NavigationService.ViewModels;
using Xamarin.Forms_NavigationService.Views;

namespace Xamarin.Forms_NavigationService.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly IDictionary<Type, Type> _viewModelRouting = new Dictionary<Type, Type>()
        {
            { typeof(FirstViewModel),  typeof(FirstView) },
            { typeof(SecondViewModel), typeof(SecondView) }
        };

        public void NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            Type pageType = _viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateTo(Type destinationType, object navigationContext = null)
        {
            Type pageType = _viewModelRouting[destinationType];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;

            if (page != null)
                Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}