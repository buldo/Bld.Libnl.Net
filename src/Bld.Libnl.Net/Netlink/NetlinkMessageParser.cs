using Bld.Libnl.Net.Nl80211;
using static Bld.Libnl.Net.LibnlPInvoke;
using static Bld.Libnl.Net.LibnlGenlPInvoke;
using Bld.Libnl.Net.Nl80211.Policies;
using Bld.Libnl.Net.Nl80211.Enums;

namespace Bld.Libnl.Net.Netlink;

public static class NetlinkMessageParser
{
    public static NetlinkMessage<TAttributeIdType> Parse<TAttributeIdType>(IntPtr msg) where TAttributeIdType : struct, Enum, IConvertible
    {

        var header = nlmsg_hdr(msg);
        var messageDataPointer = nlmsg_data(header);
        var head = genlmsg_attrdata(messageDataPointer, 0);
        var msgLen = genlmsg_attrlen(messageDataPointer, 0);

        NetlinkMessage<TAttributeIdType> message = new();
        var idValues = Enum.GetValues<TAttributeIdType>();
        var maxValue = idValues.Max().ToInt32(null);
        unsafe
        {
            var attributesArray = new nlattr*[maxValue + 1];
            nla_parse(
                attributesArray,
                maxValue,
                head,
                msgLen,
                IntPtr.Zero);

            foreach (var idValue in idValues)
            {
                var intIdValue = idValue.ToInt32(null);
                var attributePtr = attributesArray[intIdValue];
                if ( attributePtr != null)
                {
                    if (typeof(TAttributeIdType) == typeof(nl80211_attrs))
                    {
                        if (NlaPolicies.nl80211_policy.TryGetValue((nl80211_attrs)intIdValue, out var policy))
                        {
                            var attribute = policy.Type switch
                            {
                                NetlinkAttributeType.NLA_U8 => ParseU8(attributePtr, idValue),
                                NetlinkAttributeType.NLA_U16 => ParseU16(attributePtr, idValue),
                                NetlinkAttributeType.NLA_U32 => ParseU32(attributePtr, idValue),
                                NetlinkAttributeType.NLA_U64 => ParseU64(attributePtr, idValue),
                                NetlinkAttributeType.NLA_STRING => ParseString(attributePtr, idValue),
                                NetlinkAttributeType.NLA_NUL_STRING => ParseString(attributePtr, idValue),
                                _ => null
                            };
                            if (attribute != null)
                            {
                                message.AddAttribute(attribute);
                            }
                        }
                    }

                }
            }
        }

        return message;
    }

    private static unsafe IMessageAttribute<T> ParseU8<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u8(attributePtr);
        return new ValueAttribute<byte, T>(id, NetlinkAttributeType.NLA_U8, value);
    }

    private static unsafe IMessageAttribute<T> ParseU16<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u16(attributePtr);
        return new ValueAttribute<UInt16, T>(id, NetlinkAttributeType.NLA_U16, value);
    }

    private static unsafe IMessageAttribute<T> ParseU32<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u32(attributePtr);
        return new ValueAttribute<UInt32, T>(id, NetlinkAttributeType.NLA_U32, value);
    }

    private static unsafe IMessageAttribute<T> ParseU64<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u64(attributePtr);
        return new ValueAttribute<UInt64, T>(id, NetlinkAttributeType.NLA_U64, value);
    }

    private static unsafe IMessageAttribute<T> ParseString<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_stringToString(attributePtr);
        return new ValueAttribute<string?, T>(id, NetlinkAttributeType.NLA_STRING, value);
    }
}