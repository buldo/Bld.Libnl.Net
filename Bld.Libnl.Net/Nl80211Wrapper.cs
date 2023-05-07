using Bld.Libnl.Net.Handles;

using static Bld.Libnl.Net.LibnlPInvoke;

namespace Bld.Libnl.Net;

public class Nl80211Wrapper
{
    private readonly LibNlSocketHandle _libNlSocket;
    private readonly int _familyIdentifier;

    public Nl80211Wrapper()
    {

        _libNlSocket = LibnlPInvoke.nl_socket_alloc();
        if (_libNlSocket.IsInvalid)
        {
            throw new Exception("Failed to allocate netlink socket");
        }

        //libNlSocket.SetBufferSize(8192, 8192);
        _libNlSocket.Connect();

        _familyIdentifier = _libNlSocket.CtrlResolve("nl80211");

        _libNlSocket.ModifyCallback(
            LibnlPInvoke.nl_cb_type.NL_CB_VALID,
            LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
            SocketCallback,
            IntPtr.Zero);
    }

    public void SendMessage(MessageFlags flags, Nl80211Command cmd)
    {
        var messageHandle = LibnlPInvoke.nlmsg_alloc();
        if (messageHandle.IsInvalid)
        {
            throw new Exception("Failed to allocate nl message");
        }

        messageHandle.Put(
            LibnlPInvoke.NL_AUTO_PORT,
            LibnlPInvoke.NL_AUTO_SEQ,
            _familyIdentifier,
            0,
            flags,
            (byte)cmd,
            0);

        _libNlSocket.SendAuto(messageHandle);

        while (true)
        {
            _libNlSocket.RecvMsgsDefault();
        }
    }

    private int SocketCallback(IntPtr msg, IntPtr arg)
    {
        Console.WriteLine("Received");
        return (int)nl_cb_action.NL_SKIP;
    }
}