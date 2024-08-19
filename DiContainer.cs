namespace MiniJect;

public class DiContainer
{
    private readonly List<Descriptor> _descriptors;

    public DiContainer(List<Descriptor> descriptors)
    {
        _descriptors = descriptors;
    }

    public T Get<T>()
    {
        var descriptor = _descriptors
            .SingleOrDefault(entry => entry.Type == typeof(T));

        if (descriptor == null)
        {
            throw new Exception($"Type {typeof(T).Name} isn't registered.");
        }

        if (descriptor.InstanceObject != null)
        {
            return (T)descriptor.InstanceObject;
        }


        throw new Exception($"Type {typeof(T).Name} wasn't built.");
    }
}