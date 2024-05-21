using Fluxor;
using Newtonsoft.Json;

namespace BlazorStateManagementTemplate.Client.StateManagement;

public class FluxorMiddleware : Middleware
{
    private IStore Store;

    public override Task InitializeAsync(IDispatcher dispatcher, IStore store)
    {
        Store = store;
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
        Console.WriteLine(nameof(MayDispatchAction) + ObjectInfo(action));
        return base.MayDispatchAction(action);
    }

    public override void BeforeDispatch(object action)
    {
        Console.WriteLine(nameof(BeforeDispatch) + ObjectInfo(action));
        base.BeforeDispatch(action);
    }

    public override void AfterDispatch(object action)
    {
        Console.WriteLine(nameof(AfterDispatch) + ObjectInfo(action));
        base.AfterDispatch(action);
    }

    protected override void OnInternalMiddlewareChangeEnding()
    {
        Console.WriteLine("OnInternalMiddlewareChangeEnding");
        base.OnInternalMiddlewareChangeEnding();
    }

    private string ObjectInfo(object obj) => ": " + obj.GetType().Name + " " + JsonConvert.SerializeObject(obj, Formatting.Indented);
}