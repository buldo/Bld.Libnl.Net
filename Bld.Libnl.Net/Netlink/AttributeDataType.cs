namespace Bld.Libnl.Net.Netlink;

/**
 * enum netlink_attribute_type - type of an attribute
 * @NL_ATTR_TYPE_INVALID: unused
 * @NL_ATTR_TYPE_FLAG: flag attribute (present/not present)
 * @NL_ATTR_TYPE_U8: 8-bit unsigned attribute
 * @NL_ATTR_TYPE_U16: 16-bit unsigned attribute
 * @NL_ATTR_TYPE_U32: 32-bit unsigned attribute
 * @NL_ATTR_TYPE_U64: 64-bit unsigned attribute
 * @NL_ATTR_TYPE_S8: 8-bit signed attribute
 * @NL_ATTR_TYPE_S16: 16-bit signed attribute
 * @NL_ATTR_TYPE_S32: 32-bit signed attribute
 * @NL_ATTR_TYPE_S64: 64-bit signed attribute
 * @NL_ATTR_TYPE_BINARY: binary data, min/max length may be specified
 * @NL_ATTR_TYPE_STRING: string, min/max length may be specified
 * @NL_ATTR_TYPE_NUL_STRING: NUL-terminated string,
 *	min/max length may be specified
 * @NL_ATTR_TYPE_NESTED: nested, i.e. the content of this attribute
 *	consists of sub-attributes. The nested policy and maxtype
 *	inside may be specified.
 * @NL_ATTR_TYPE_NESTED_ARRAY: nested array, i.e. the content of this
 *	attribute contains sub-attributes whose type is irrelevant
 *	(just used to separate the array entries) and each such array
 *	entry has attributes again, the policy for those inner ones
 *	and the corresponding maxtype may be specified.
 * @NL_ATTR_TYPE_BITFIELD32: &struct nla_bitfield32 attribute
 */
public enum NetlinkAttributeType
{
    NL_ATTR_TYPE_INVALID,

    NL_ATTR_TYPE_FLAG,

    NL_ATTR_TYPE_U8,
    NL_ATTR_TYPE_U16,
    NL_ATTR_TYPE_U32,
    NL_ATTR_TYPE_U64,

    NL_ATTR_TYPE_S8,
    NL_ATTR_TYPE_S16,
    NL_ATTR_TYPE_S32,
    NL_ATTR_TYPE_S64,

    NL_ATTR_TYPE_BINARY,
    NL_ATTR_TYPE_STRING,
    NL_ATTR_TYPE_NUL_STRING,

    NL_ATTR_TYPE_NESTED,
    NL_ATTR_TYPE_NESTED_ARRAY,

    NL_ATTR_TYPE_BITFIELD32,
};