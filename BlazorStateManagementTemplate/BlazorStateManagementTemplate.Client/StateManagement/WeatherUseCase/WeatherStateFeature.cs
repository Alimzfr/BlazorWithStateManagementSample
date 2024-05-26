using BlazorStateManagementTemplate.Client.DataTransferObjects;
using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public class WeatherStateFeature : Feature<WeatherState>
{
    public override string GetName() => nameof(WeatherState);

    protected override WeatherState GetInitialState()
    {
        return new WeatherState
        {
            Loading = false,
            Initialized = false,
            WeatherForecasts = new WeatherForecastDto[] { }
        };
    }
}