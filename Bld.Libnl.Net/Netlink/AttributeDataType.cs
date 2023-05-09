namespace Bld.Libnl.Net.Netlink;

public enum AttributeDataType
{
    /// <summary>
    /// Unspecified type, binary data chunk
    /// </summary>
    NLA_UNSPEC,

    /// <summary>
    /// 8 bit integer
    /// </summary>
    NLA_U8,

    /// <summary>
    /// 16 bit integer
    /// </summary>
    NLA_U16,

    /// <summary>
    /// 32 bit integer
    /// </summary>
    NLA_U32,

    /// <summary>
    /// 64 bit integer
    /// </summary>
    NLA_U64,

    /// <summary>
    /// NUL terminated character string
    /// </summary>
    NLA_STRING,

    /// <summary>
    /// Flag
    /// </summary>
    NLA_FLAG,

    /// <summary>
    /// Micro seconds (64bit)
    /// </summary>
    NLA_MSECS,

    /// <summary>
    /// Nested attributes
    /// </summary>
    NLA_NESTED
}