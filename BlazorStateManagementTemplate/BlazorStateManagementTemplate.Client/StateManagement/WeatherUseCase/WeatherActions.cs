using BlazorStateManagementTemplate.Client.DataTransferObjects;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public class WeatherActions
{
    public class SetLoadingAction
    {
        public required bool IsLoading { get; set; }
    }

    public class SetInitializedAction
    {
        public required bool IsInitialized { get; set; }
    }

    public class SetWeatherForecastsAction
    {
        public required IEnumerable<WeatherForecastDto> WeatherForecasts { get; set; }
    }

    public class LoadWeatherForecastsAction
    {
        public required CancellationToken CancellationToken { get; set; }
    }
}