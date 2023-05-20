namespace Bld.Libnl.Net.Netlink;

public class NetlinkMessage<TAttributeIdType>
{
    public List<IMessageAttribute<TAttributeIdType>> Attributes { get; } = new();
}