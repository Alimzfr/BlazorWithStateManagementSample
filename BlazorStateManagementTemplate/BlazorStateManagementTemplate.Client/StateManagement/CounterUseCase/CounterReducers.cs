using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement.CounterUseCase;

public class CounterReducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, CounterActions.IncrementCounterAction action)
    {
        return state with
        {
            Counter = state.Counter + 1
        };
    }
}