using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement.WeatherUseCase;

public class WeatherReducers
{
    [ReducerMethod]
    public static WeatherState ReduceSetLoadingAction(WeatherState state, WeatherActions.SetLoadingAction action)
    {
        return state with
        {
            Loading = action.IsLoading
        };
    }

    [ReducerMethod]
    public static WeatherState ReduceSetInitializedAction(WeatherState state, WeatherActions.SetInitializedAction action)
    {
        return state with
        {
            Initialized = action.IsInitialized
        };
    }

    [ReducerMethod]
    public static WeatherState ReduceSetWeatherForecastsAction(WeatherState state, WeatherActions.SetWeatherForecastsAction action)
    {
        return state with
        {
            WeatherForecasts = action.WeatherForecasts
        };
    }

    [ReducerMethod]
    public static WeatherState ReduceLoadWeatherForecastsAction(WeatherState state, WeatherActions.LoadWeatherForecastsAction action)
    {
        return state;
    }
}