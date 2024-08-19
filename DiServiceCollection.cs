namespace MiniJect;

public class DiServiceCollection
{
    private List<Descriptor> _collection = new();

    public void RegisterSingleton<T>()
    {
        throw new NotImplementedException();
    }

    public void RegisterSingleton<T>(T instance)
    {
        _collection.Add(new Descriptor(instance, ELifetimeType.Singleton));
    }

    public DiContainer GetContainer()
    {
        return new DiContainer(_collection);
    }
}