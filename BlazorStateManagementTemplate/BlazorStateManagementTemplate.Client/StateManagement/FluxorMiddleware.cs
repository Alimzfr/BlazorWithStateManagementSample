using Fluxor;

namespace BlazorStateManagementTemplate.Client.StateManagement;

public class FluxorMiddleware : Middleware
{
    private IStore _store;

    public override Task InitializeAsync(IDispatcher dispatcher, IStore store)
    {
        _store = store;
        Console.WriteLine(nameof(InitializeAsync));
        return base.InitializeAsync(dispatcher, store);
    }

    public override void AfterInitializeAllMiddlewares()
    {
        Console.WriteLine(nameof(AfterInitializeAllMiddlewares));
        base.AfterInitializeAllMiddlewares();
    }

    public override bool MayDispatchAction(object action)
    {
        Console.WriteLine($"{nameof(MayDispatchAction)}: {action.GetType().Name}");
        return base.MayDispatchAction(action);
    }

    public override void BeforeDispatch(object action)
    {
        Console.WriteLine($"{nameof(BeforeDispatch)}: {action.GetType().Name}");
        base.BeforeDispatch(action);
    }

    public override void AfterDispatch(object action)
    {
        Console.WriteLine($"{nameof(AfterDispatch)}: {action.GetType().Name}");
        base.AfterDispatch(action);
    }

    protected override void OnInternalMiddlewareChangeEnding()
    {
        Console.WriteLine(nameof(OnInternalMiddlewareChangeEnding));
        base.OnInternalMiddlewareChangeEnding();
    }
}