namespace Bld.Libnl.Net.Nl80211;

public enum NetlinkAttributeType
{
    NLA_UNSPEC,
    NLA_U8,
    NLA_U16,
    NLA_U32,
    NLA_U64,
    NLA_STRING,
    NLA_FLAG,
    NLA_MSECS,
    NLA_NESTED,
    NLA_NESTED_ARRAY,
    NLA_NUL_STRING,
    NLA_BINARY,
    NLA_S8,
    NLA_S16,
    NLA_S32,
    NLA_S64,
    NLA_BITFIELD32,
    NLA_REJECT,
    NLA_BE16,
    NLA_BE32,
    
    // Custom
    NLA_NESTED_IFTYPES,
};