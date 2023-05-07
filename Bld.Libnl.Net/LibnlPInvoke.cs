using System.Runtime.InteropServices;
using Bld.Libnl.Net.Handles;

namespace Bld.Libnl.Net;

public static partial class LibnlPInvoke
{
    private const string LibName = "libnl-3.so.200";

    public const UInt32 NL_AUTO_PORT = 0;
    public const UInt32 NL_AUTO_SEQ = 0;

    /// <summary>
    /// nl_recvmsgs() callback for message processing customization
    /// msg netlink message being processed
    /// arg argument passwd on through caller
    /// </summary>
    public delegate int nl_recvmsg_msg_cb_t(IntPtr msg, IntPtr arg);

    /// <summary>
    /// Allocate new netlink socket
    /// </summary>
    /// <returns>Newly allocated netlink socket or NULL</returns>
    [LibraryImport(LibName, EntryPoint = "nl_socket_alloc")]
    public static partial LibNlSocketHandle nl_socket_alloc();

    /// <summary>
    /// Close Netlink socket
    /// </summary>
    /// <param name="sk">Netlink socket (required)</param>
    /// <remarks>
    /// The socket is closed automatically if a `struct nl_sock` object is
    /// freed using `nl_socket_free()`
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nl_close")]
    public static partial void nl_close(IntPtr sk);

    /// <summary>
    /// Free a netlink socket
    /// </summary>
    /// <param name="sk">Netlink socket</param>
    [LibraryImport(LibName, EntryPoint = "nl_socket_free")]
    public static partial void nl_socket_free(IntPtr sk);

    /// <summary>
    /// Set socket buffer size of netlink socket
    /// Sets the socket buffer size of a netlink socket to the specified
    /// values rxbuf and txbuf. Providing a value of 0 assumes a
    /// good default value
    /// </summary>
    /// <param name="nl_sock">Netlink socket</param>
    /// <param name="rxbuf">New receive socket buffer size in bytes</param>
    /// <param name="txbuf">New transmit socket buffer size in bytes</param>
    /// <returns>0 on sucess or a negative error code</returns>
    /// <remarks>
    /// It is not required to call this function prior to nl_connect().
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nl_socket_set_buffer_size")]
    public static partial int nl_socket_set_buffer_size(IntPtr nl_sock, int rxbuf, int txbuf);

    /// <summary>
    /// Allocate a new callback handle
    /// </summary>
    /// <param name="kind">callback kind to be used for initialization</param>
    /// <returns>Newly allocated callback handle or NULL</returns>
    [LibraryImport(LibName, EntryPoint = "nl_cb_alloc")]
    public static partial CallbackHandle nl_cb_alloc(nl_cb_kind kind);

    /// <summary>
    ///
    /// </summary>
    /// <param name="cb"></param>
    /// <param name="type"></param>
    /// <param name="kind"></param>
    /// <param name="func"></param>
    /// <param name="arg"></param>
    /// <returns></returns>
    [LibraryImport(LibName, EntryPoint = "nl_cb_set")]
    public static partial int nl_cb_set(IntPtr cb, nl_cb_type type, nl_cb_kind kind, nl_recvmsg_msg_cb_t func, IntPtr arg);

    /// <summary>
    /// Allocate a new netlink message with the default maximum payload size.
    /// </summary>
    /// <returns>Newly allocated netlink message or NULL</returns>
    /// <remarks>
    /// Allocates a new netlink message without any further payload. The
    /// maximum payload size defaults to PAGESIZE or as otherwise specified
    /// with nlmsg_set_default_size().
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nlmsg_alloc")]
    public static partial NetlinkMessageHandle nlmsg_alloc();


    /// <summary>
    /// Release a reference from an netlink message
    /// </summary>
    /// <param name="msg">message to release reference from</param>
    /// <remarks>
    /// Frees memory after the last reference has been released.
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nlmsg_free")]
    public static partial void nlmsg_free(IntPtr msg);

    /// <summary>
    /// Callback types
    /// </summary>
    public enum nl_cb_type {
        /// <summary>
        /// Message is valid
        /// </summary>
        NL_CB_VALID,

        /// <summary>
        /// Last message in a series of multi part messages received
        /// </summary>
        NL_CB_FINISH,

        /// <summary>
        /// Report received that data was lost
        /// </summary>
        NL_CB_OVERRUN,

        /// <summary>
        /// Message wants to be skipped
        /// </summary>
        NL_CB_SKIPPED,

        /// <summary>
        /// Message is an acknowledge
        /// </summary>
        NL_CB_ACK,

        /// <summary>
        /// Called for every message received
        /// </summary>
        NL_CB_MSG_IN,

        /// <summary>
        /// Called for every message sent out except for nl_sendto()
        /// </summary>
        NL_CB_MSG_OUT,

        /// <summary>
        /// Message is malformed and invalid
        /// </summary>
        NL_CB_INVALID,

        /// <summary>
        /// Called instead of internal sequence number checking
        /// </summary>
        NL_CB_SEQ_CHECK,

        /// <summary>
        /// Sending of an acknowledge message has been requested
        /// </summary>
        NL_CB_SEND_ACK,

        /// <summary>
        /// Flag NLM_F_DUMP_INTR is set in message
        /// </summary>
        NL_CB_DUMP_INTR,
    };

    public enum nl_cb_kind
    {
        /// <summary>
        /// Default handlers (quiet)
        /// </summary>
        NL_CB_DEFAULT,

        /// <summary>
        /// Verbose default handlers (error messages printed)
        /// </summary>
        NL_CB_VERBOSE,

        /// <summary>
        /// Debug handlers for debugging
        /// </summary>
        NL_CB_DEBUG,

        /// <summary>
        /// Customized handler specified by the user
        /// </summary>
        NL_CB_CUSTOM,
    };
}