using BlazorStateManagementTemplate.Client.DataTransferObjects;

namespace BlazorStateManagementTemplate.Client.Services;

public interface IWeatherService
{
    Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastsAsync(CancellationToken cancellationToken = default(CancellationToken));
}