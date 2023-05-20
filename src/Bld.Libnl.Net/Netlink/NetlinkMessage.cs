namespace Bld.Libnl.Net.Netlink;

public class NetlinkMessage<TAttributeIdType> where TAttributeIdType : Enum
{
    public Dictionary<TAttributeIdType, IMessageAttribute<TAttributeIdType>> Attributes { get; } = new();

    public void AddAttribute(IMessageAttribute<TAttributeIdType> attr)
    {
        Attributes.Add(attr.Id, attr);
    }
}