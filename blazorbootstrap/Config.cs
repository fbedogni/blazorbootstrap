﻿using BlazorBootstrap;

namespace Microsoft.Extensions.DependencyInjection;

public static class Config
{
    #region Methods

    /// <summary>
    /// Adds a bootstrap providers and component mappings.
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <returns>IServiceCollection</returns>
    public static IServiceCollection AddBlazorBootstrap(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<BootstrapClassProvider>();
        serviceCollection.AddSingleton<BootstrapIconProvider>();
        serviceCollection.AddScoped<IIdGenerator, IdGenerator>();

        serviceCollection.AddScoped<BreadcrumbService>();
        serviceCollection.AddScoped<ModalService>();
        serviceCollection.AddScoped<PreloadService>();
        serviceCollection.AddScoped<ToastService>();

        return serviceCollection;
    }

    #endregion
}
