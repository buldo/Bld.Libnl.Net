﻿namespace Bld.Libnl.Net.Netlink;

public interface IMessageAttribute<out TAttributeIdType>
{
    TAttributeIdType Id { get; }

    NetlinkAttributeType Type { get; }

    object GetValue();
}