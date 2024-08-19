namespace MiniJect;

public class Descriptor
{
    public Type Type { get; }
    public object InstanceObject { get; }
    public ELifetimeType LifetimeType { get; }

    public Descriptor(object @object, ELifetimeType lifetimeType)
    {
        InstanceObject = @object;
        Type = @object.GetType();
        LifetimeType = lifetimeType;
    }
}