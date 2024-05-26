using BlazorStateManagementTemplate.Client.Services;
using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public class WeatherEffects(IWeatherService weatherService)
{
    [EffectMethod]
    public async Task EffectLoadWeatherForecastsAction(WeatherActions.LoadWeatherForecastsAction action, IDispatcher dispatcher)
    {
        dispatcher.Dispatch(new WeatherActions.SetLoadingAction { IsLoading = true });
        var weatherForecasts = await weatherService.GetWeatherForecastsAsync(action.CancellationToken);
        dispatcher.Dispatch(new WeatherActions.SetWeatherForecastsAction { WeatherForecasts = weatherForecasts });
        dispatcher.Dispatch(new WeatherActions.SetLoadingAction { IsLoading = false });
        dispatcher.Dispatch(new WeatherActions.SetInitializedAction { IsInitialized = true });
    }
}