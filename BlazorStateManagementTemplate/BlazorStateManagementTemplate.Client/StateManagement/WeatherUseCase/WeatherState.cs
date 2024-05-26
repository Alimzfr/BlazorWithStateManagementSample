using BlazorStateManagementTemplate.Client.DataTransferObjects;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public record WeatherState
{
    public bool Loading { get; init; }
    public bool Initialized { get; init; }
    public IEnumerable<WeatherForecastDto> WeatherForecasts { get; init; }
}