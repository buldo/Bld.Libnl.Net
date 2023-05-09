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
                        AttributeDataType.NLA_UNSPEC => null,
                        AttributeDataType.NLA_U8 => ParseU8(attributePtr, idValue),
                        AttributeDataType.NLA_U16 => null,
                        AttributeDataType.NLA_U32 => ParseU32(attributePtr, idValue),
                        AttributeDataType.NLA_U64 => null,
                        AttributeDataType.NLA_STRING => ParseString(attributePtr, idValue),
                        AttributeDataType.NLA_FLAG => null,
                        AttributeDataType.NLA_MSECS => null,
                        AttributeDataType.NLA_NESTED => null,
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
        return new ValueAttribute<byte, T>(id, AttributeDataType.NLA_U8, value);
    }

    private static unsafe IMessageAttribute<T> ParseU32<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_u32(attributePtr);
        return new ValueAttribute<UInt32, T>(id, AttributeDataType.NLA_U32, value);
    }

    private static unsafe IMessageAttribute<T> ParseString<T>(nlattr* attributePtr, T id)
    {
        var value = nla_get_stringToString(attributePtr);
        return new ValueAttribute<string?, T>(id, AttributeDataType.NLA_STRING, value);
    }
}