using System.Runtime.CompilerServices;
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
    /// nl_recvmsgs() callback for error message processing customization
    /// </summary>
    /// <param name="nla">netlink address of the peer</param>
    /// <param name="nlerr">netlink error message being processed</param>
    /// <param name="arg">argument passed on through caller</param>
    /// <returns></returns>
    public delegate int nl_recvmsg_err_cb_t(IntPtr nla, IntPtr nlerr, IntPtr arg);

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
    /// Modify the callback handler associated with the socket
    /// </summary>
    /// <param name="sk">Netlink socket</param>
    /// <param name="type">which type callback to set</param>
    /// <param name="kind">kind of callback</param>
    /// <param name="func">callback function</param>
    /// <param name="arg">argument to be passed to callback function</param>
    /// <returns>0 on success or a negative error code</returns>
    [LibraryImport(LibName, EntryPoint = "nl_socket_modify_cb")]
    public static partial int nl_socket_modify_cb(
        IntPtr sk,
        nl_cb_type type,
        nl_cb_kind kind,
        nl_recvmsg_msg_cb_t func,
        IntPtr arg);

    /// <summary>
    /// Set up a callback
    /// </summary>
    /// <param name="cb">callback set</param>
    /// <param name="type">callback to modify</param>
    /// <param name="kind">kind of implementation</param>
    /// <param name="func">callback function (NL_CB_CUSTOM)</param>
    /// <param name="arg">argument passed to callback</param>
    /// <returns></returns>
    [LibraryImport(LibName, EntryPoint = "nl_cb_set")]
    public static partial int nl_cb_set(IntPtr cb, nl_cb_type type, nl_cb_kind kind, nl_recvmsg_msg_cb_t func,
        IntPtr arg);

    /// <summary>
    /// Set up an error callback
    /// </summary>
    /// <param name="cb">callback set</param>
    /// <param name="kind">kind of callback</param>
    /// <param name="func">callback function</param>
    /// <param name="arg">argument to be passed to callback function</param>
    /// <returns></returns>
    [LibraryImport(LibName, EntryPoint = "nl_cb_err")]
    public static partial int nl_cb_err(IntPtr cb, nl_cb_kind kind, nl_recvmsg_err_cb_t func, IntPtr arg);

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
    /// Finalize and transmit Netlink message
    /// </summary>
    /// <param name="sk">Netlink socket (required)</param>
    /// <param name="msg">Netlink message (required)</param>
    /// <returns>Number of bytes sent or a negative error code.</returns>
    /// <remarks>
    /// Finalizes the message by passing it to `nl_complete_msg()` and transmits it
    /// by passing it to `nl_send()`.
    /// This function triggers the `NL_CB_MSG_OUT` callback.
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nl_send_auto")]
    public static partial int nl_send_auto(IntPtr sk, IntPtr msg);

    /// <summary>
    /// Receive a set of message from a netlink socket using handlers in nl_sock.
    /// </summary>
    /// <param name="sk">Netlink socket</param>
    /// <returns>0 on success or a negative error code from nl_recv()</returns>
    /// <remarks>
    /// Calls nl_recvmsgs() with the handlers configured in the netlink socket
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nl_recvmsgs_default")]
    public static partial int nl_recvmsgs_default(IntPtr sk);

    /// <summary>
    /// Return actual netlink message
    /// </summary>
    /// <param name="n">netlink message</param>
    /// <returns>A pointer to the netlink message.</returns>
    /// <remarks>
    /// Returns the actual netlink message casted to the type of the netlink
    /// message header.
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nlmsg_hdr")]
    public static partial IntPtr nlmsg_hdr(IntPtr n);

    /// <summary>
    /// Return pointer to message payload
    /// </summary>
    /// <param name="nlh">Netlink message header</param>
    /// <returns>Pointer to start of message payload.</returns>
    [LibraryImport(LibName, EntryPoint = "nlmsg_data")]
    public static partial IntPtr nlmsg_data(IntPtr nlh);

    /// <summary>
    /// Create attribute index based on a stream of attributes
    /// </summary>
    /// <param name="tb">Index array to be filled (maxtype+1 elements)</param>
    /// <param name="maxtype">Maximum attribute type expected and accepted</param>
    /// <param name="head">Head of attribute stream</param>
    /// <param name="len">Length of attribute stream</param>
    /// <param name="policy">Attribute validation policy</param>
    /// <returns>0 on success or a negative error code</returns>
    /// <remarks>
    /// Iterates over the stream of attributes and stores a pointer to each
    /// attribute in the index array using the attribute type as index to
    /// the array. Attribute with a type greater than the maximum type
    /// specified will be silently ignored in order to maintain backwards
    /// compatibility. If a policy is not NULL, the attribute will be
    /// validated using the specified policy
    /// </remarks>
    [LibraryImport(LibName, EntryPoint = "nla_parse")]
    public static unsafe partial int nla_parse(nlattr* []tb, int maxtype, IntPtr head, int len, IntPtr policy);

    /// <summary>
    /// Callback actions
    /// </summary>
    public enum nl_cb_action
    {
        /// <summary>
        /// Proceed with wathever would come next
        /// </summary>
        NL_OK,

        /// <summary>
        /// Skip this message
        /// </summary>
        NL_SKIP,

        /// <summary>
        /// Stop parsing altogether and discard remaining messages
        /// </summary>
        NL_STOP,
    };

    /// <summary>
    /// Callback types
    /// </summary>
    public enum nl_cb_type
    {
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

[StructLayout(LayoutKind.Sequential)]
public struct nlattr
{
    UInt16 nla_len;
    UInt16 nla_type;
};