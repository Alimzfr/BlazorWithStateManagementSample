using BlazorStateManagementTemplate.Client.DataTransferObjects;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public class WeatherActions
{
    public record SetLoadingAction(bool IsLoading);

    public record SetInitializedAction(bool IsInitialized);

    public record SetWeatherForecastsAction(IEnumerable<WeatherForecastDto> WeatherForecasts);

    public record LoadWeatherForecastsAction(CancellationToken CancellationToken);
}