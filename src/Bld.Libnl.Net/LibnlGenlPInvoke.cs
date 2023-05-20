using System;
using System.Runtime.InteropServices;

namespace Bld.Libnl.Net;

public static partial class LibnlGenlPInvoke
{
    private const string LibName = "libnl-genl-3.so.200";

    /// <summary>
    /// Connect a Generic Netlink socket
    /// This function expects a struct nl_socket object previously allocated via
    /// nl_socket_alloc(). It calls nl_connect() to create the local socket file
    /// descriptor and binds the socket to the \c NETLINK_GENERIC Netlink protocol.
    ///
    /// Using this function is equivalent to:
    /// nl_connect(sk, NETLINK_GENERIC);
    /// </summary>
    /// <param name="sk">Unconnected Netlink socket</param>
    /// <returns>0 on success or a negative error code</returns>
    [LibraryImport(LibName, EntryPoint = "genl_connect")]
    public static partial int genl_connect(IntPtr sk);

    /// <summary>
    /// Resolve Generic Netlink family name to numeric identifier
    /// </summary>
    /// <param name="sk">Generic Netlink socket</param>
    /// <param name="name">Name of Generic Netlink family</param>
    /// <returns>The numeric family identifier or a negative error code.</returns>
    /// <remarks>
    /// Resolves the Generic Netlink family name to the corresponding numeric
    /// family identifier. This function queries the kernel directly, use
    /// genl_ctrl_search_by_name() if you need to resolve multiple names.
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "genl_ctrl_resolve", StringMarshalling = StringMarshalling.Utf8)]
    public static partial int genl_ctrl_resolve(IntPtr sk, string name);

    /// <summary>
    /// Add Generic Netlink headers to Netlink message
    /// </summary>
    /// <param name="msg">Netlink message object</param>
    /// <param name="port">Netlink port or NL_AUTO_PORT</param>
    /// <param name="seq">Sequence number of message or NL_AUTO_SEQ</param>
    /// <param name="family">Numeric family identifier</param>
    /// <param name="hdrlen">Length of user header</param>
    /// <param name="flags">Additional Netlink message flags (optional)</param>
    /// <param name="cmd">Numeric command identifier</param>
    /// <param name="version">Interface version</param>
    /// <returns>Pointer to user header or NULL if an error occurred</returns>
    /// <remarks>
    /// Calls nlmsg_put() on the specified message object to reserve space for
    /// the Netlink header, the Generic Netlink header, and a user header of
    /// specified length.Fills out the header fields with the specified
    /// parameters.
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "genlmsg_put")]
    public static partial IntPtr genlmsg_put(IntPtr msg, UInt32 port, UInt32 seq, int family, int hdrlen, MessageFlags flags, byte cmd, byte version);

    /// <summary>
    /// Return pointer to message attributes
    /// </summary>
    /// <param name="gnlh">Generic Netlink message header</param>
    /// <param name="hdrlen">Length of user header</param>
    /// <returns>Pointer to the start of the message's attributes section.</returns>
    [LibraryImport(LibName, EntryPoint = "genlmsg_attrdata")]
    public static partial IntPtr genlmsg_attrdata(IntPtr gnlh, int hdrlen);

    /// <summary>
    /// Return length of message attributes
    /// </summary>
    /// <param name="gnlh">Generic Netlink message header</param>
    /// <param name="hdrlen">Length of user header</param>
    /// <returns>Length of the message section containing attributes in number of bytes</returns>
    [LibraryImport(LibName, EntryPoint = "genlmsg_attrlen")]
    public static partial int genlmsg_attrlen(IntPtr gnlh, int hdrlen);
}