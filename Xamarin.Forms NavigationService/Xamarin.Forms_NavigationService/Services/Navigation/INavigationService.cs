﻿using System;

namespace Xamarin.Forms_NavigationService.Services.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TDestinationViewModel>(object navigationContext = null);

        void NavigateTo(Type destinationType, object navigationContext = null);

        void NavigateBack();
    }
}
