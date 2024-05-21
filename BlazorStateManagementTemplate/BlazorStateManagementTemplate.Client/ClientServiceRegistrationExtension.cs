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
            options.UseReduxDevTools();
#endif
        });
    }
}