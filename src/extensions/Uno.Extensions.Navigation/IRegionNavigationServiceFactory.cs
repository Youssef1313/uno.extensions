﻿using System;
using Uno.Extensions.Navigation.Regions;

namespace Uno.Extensions.Navigation;

public interface IRegionNavigationServiceFactory
{
    void RegisterNavigator<TNavigator>(params string[] names) where TNavigator : INavigationService;

    INavigationService CreateService(IRegion region);

    INavigationService CreateService(IServiceProvider services, NavigationRequest request);
}
