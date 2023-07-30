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
                    // Console.WriteLine((nl80211_attrs)intIdValue);
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
                                NetlinkAttributeType.NLA_NESTED_IFTYPES => ParseNestedIfTypes(attributePtr, idValue),
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

    private static unsafe IMessageAttribute<T> ParseNestedIfTypes<T>(nlattr* attributePtr, T id)
    {
        // printf("\tSupported interface modes:\n");
        // nla_for_each_nested(nl_mode, tb_msg[NL80211_ATTR_SUPPORTED_IFTYPES], rem_mode)
        //     printf("\t\t * %s\n", iftype_name(nla_type(nl_mode)));
        
        
        // pos	loop counter, set to current attribute
        // nla	attribute containing the nested attributes
        // rem	initialized to len, holds bytes currently remaining in stream
        // nla_for_each_nested(pos, nla, rem)
        //      for (pos = nla_data(nla), rem = nla_len(nla); nla_ok(pos, rem); pos = nla_next(pos, &(rem)))

        List<IfMode> modes = new List<IfMode>();
        void* pos = null;
        int rem = -1;
        for (pos = nla_data(attributePtr), rem = nla_len(attributePtr); 
             nla_ok((nlattr*)pos, rem) != 0; 
             pos = nla_next((nlattr*)pos, &(rem)))
        {
            var nlaType = nla_type((nlattr*)pos);
            var mode = (IfMode)nlaType;
            modes.Add(mode);
        }

        return new ValueAttribute<IfMode[], T>(id, NetlinkAttributeType.NLA_NESTED_ARRAY, modes.ToArray());
    }
}