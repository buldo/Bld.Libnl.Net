using Bld.Libnl.Net.Nl80211;
using static Bld.Libnl.Net.LibnlPInvoke;
using static Bld.Libnl.Net.LibnlGenlPInvoke;

namespace Bld.Libnl.Net.Netlink;

public static class NetlinkMessageParser
{
    public static NetlinkMessage<TAttributeIdType> Parse<TAttributeIdType>(IntPtr msg) where TAttributeIdType : struct, Enum, IConvertible
    {

        var header = nlmsg_hdr(msg);
        var messageDataPointer = nlmsg_data(header);
        var head = genlmsg_attrdata(messageDataPointer, 0);
        var msgLen = genlmsg_attrlen(messageDataPointer, 0);

        var wiPhy = new WiphyMessage();
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
                var attributePtr = attributesArray[idValue.ToInt32(null)];
                if ( attributePtr != null)
                {
                    var attrType = nla_type(attributePtr);
                    var attribute = attrType switch
                    {
                        NetlinkAttributeType.NL_ATTR_TYPE_U8 => ParseU8(attributePtr, idValue),
                        NetlinkAttributeType.NL_ATTR_TYPE_U32 => ParseU32(attributePtr, idValue),
                        NetlinkAttributeType.NL_ATTR_TYPE_STRING => ParseString(attributePtr, idValue),
                        NetlinkAttributeType.NL_ATTR_TYPE_NUL_STRING => ParseString(attributePtr, idValue),
                        _ => null
                    };
                    if (attribute != null)
                    {
                        message.Attributes.Add(attribute);
                    }
                }
            }
        }

        return message;
    }

    private static unsafe IMessageAttribute<T> ParseU8<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u8(attributePtr);
        return new ValueAttribute<byte, T>(id, NetlinkAttributeType.NL_ATTR_TYPE_U8, value);
    }

    private static unsafe IMessageAttribute<T> ParseU32<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u32(attributePtr);
        return new ValueAttribute<UInt32, T>(id, NetlinkAttributeType.NL_ATTR_TYPE_U32, value);
    }

    private static unsafe IMessageAttribute<T> ParseString<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_stringToString(attributePtr);
        return new ValueAttribute<string?, T>(id, NetlinkAttributeType.NL_ATTR_TYPE_STRING, value);
    }
}