using Bld.Libnl.Net.Handles;

namespace Bld.Libnl.Net;

public class LibnlWrapper
{
    private readonly Nl80211State _state;

    private readonly CallbackHandle _callBack;

    public LibnlWrapper()
    {

        var libNlSocket = LibnlPInvoke.nl_socket_alloc();
        if (libNlSocket.IsInvalid)
        {
            throw new Exception("Failed to allocate netlink socket");
        }

        libNlSocket.SetBufferSize(8192, 8192);
        libNlSocket.Connect();

        var familyIdentifier = libNlSocket.CtrlResolve("nl80211");

        _state = new Nl80211State
        {
            LibNlSocket = libNlSocket,
            FamilyIdentifier = familyIdentifier
        };

        _callBack = LibnlPInvoke.nl_cb_alloc(LibnlPInvoke.nl_cb_kind.NL_CB_DEFAULT);
        if (_callBack.IsInvalid)
        {
            throw new Exception("Failed to allocate netlink callback");
        }

        _callBack.Set(LibnlPInvoke.nl_cb_type.NL_CB_VALID, LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,Func1, IntPtr.Zero);
        _callBack.Set(LibnlPInvoke.nl_cb_type.NL_CB_VALID, LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,Func2, IntPtr.Zero);

    }

    public NetlinkMessageHandle CreateMessage()
    {
        var handle = LibnlPInvoke.nlmsg_alloc();
        if (handle.IsInvalid)
        {
            throw new Exception("Failed to allocate nl message");
        }

        return handle;
    }


    private int Func2(IntPtr msg, IntPtr arg)
    {
        throw new NotImplementedException();
    }

    private int Func1(IntPtr msg, IntPtr arg)
    {
        throw new NotImplementedException();
    }
}