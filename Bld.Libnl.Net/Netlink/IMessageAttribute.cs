namespace Bld.Libnl.Net.Netlink;

public interface IMessageAttribute<out TAttributeIdType>
{
    TAttributeIdType Id { get; }

    AttributeDataType Type { get; }

    object GetValue();
}