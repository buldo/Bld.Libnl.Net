using Bld.Libnl.Net.Nl80211;

namespace Bld.Libnl.Net.Netlink;

public interface IMessageAttribute<out TAttributeIdType>
{
    TAttributeIdType Id { get; }

    NetlinkAttributeType Type { get; }

    object GetValue();
}