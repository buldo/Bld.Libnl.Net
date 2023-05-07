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
}