namespace Bld.Libnl.Net.Netlink;

public class ValueAttribute<T, TAttributeIdType> : IMessageAttribute<TAttributeIdType>
{
    public ValueAttribute(TAttributeIdType id, AttributeDataType type, T value)
    {
        Id = id;
        Type = type;
        Value = value;
    }

    public TAttributeIdType Id { get; }

    public AttributeDataType Type { get; }

    public T Value { get; }

    public object GetValue()
    {
        return Value;
    }
}