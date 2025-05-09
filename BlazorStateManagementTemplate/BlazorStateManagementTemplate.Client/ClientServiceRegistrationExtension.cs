using BlazorStateManagementTemplate.Client.Services;
using BlazorStateManagementTemplate.Client.StateManagement;
using Fluxor;

namespace BlazorStateManagementTemplate.Client;

public static class ClientServiceRegistrationExtension
{
    public static void AddClientServices(this IServiceCollection services)
    {
        services.AddFluxor(options =>
        {
            options.ScanAssemblies(typeof(Program).Assembly).AddMiddleware<FluxorMiddleware>();
#if DEBUG
            Fluxor.Blazor.Web.ReduxDevTools.OptionsReduxDevToolsExtensions.UseReduxDevTools(options);
#endif
        });

        services.AddScoped<IWeatherService, WeatherService>();
    }
}