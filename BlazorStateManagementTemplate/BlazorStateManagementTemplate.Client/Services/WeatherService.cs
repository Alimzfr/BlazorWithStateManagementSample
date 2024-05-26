using BlazorStateManagementTemplate.Client.DataTransferObjects;

namespace BlazorStateManagementTemplate.Client.Services;

public class WeatherService : IWeatherService
{
    public async Task<IEnumerable<WeatherForecastDto>> GetWeatherForecastsAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        // Simulate asynchronous loading to demonstrate streaming rendering
        await Task.Delay(1000, cancellationToken);

        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        return Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }
}