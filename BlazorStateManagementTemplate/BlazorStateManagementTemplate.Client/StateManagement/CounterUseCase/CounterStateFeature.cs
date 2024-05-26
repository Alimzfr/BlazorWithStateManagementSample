using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement.CounterUseCase;

public class CounterStateFeature : Feature<CounterState>
{
    public override string GetName() => nameof(CounterState);

    protected override CounterState GetInitialState()
    {
        return new CounterState
        {
            Counter = 0
        };
    }
}