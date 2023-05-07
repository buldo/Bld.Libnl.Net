using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Bld.Libnl.Net;

public class CallbackHandler : SafeHandle
{
    public CallbackHandler(IntPtr invalidHandleValue, bool ownsHandle) : base(invalidHandleValue, ownsHandle)
    {
    }

    protected override bool ReleaseHandle()
    {
        throw new NotImplementedException();
    }

    public override bool IsInvalid => handle == IntPtr.Zero;
}

public class LibnlWrapper
{
    private readonly Nl80211State _state;

    private readonly IntPtr _callBack1;
    private readonly IntPtr _callBack2;

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

        _state = new Nl80211State()
        {
            LibNlSocket = libNlSocket,
            FamilyIdentifier = familyIdentifier
        };

        // _callBack1 = LibnlPInvoke.nl_cb_alloc(LibnlPInvoke.nl_cb_kind.NL_CB_DEFAULT);
        // _callBack2 = LibnlPInvoke.nl_cb_alloc(LibnlPInvoke.nl_cb_kind.NL_CB_DEFAULT);
        // if (_callBack1 == IntPtr.Zero || _callBack2 == IntPtr.Zero)
        // {
        //     LibnlPInvoke.nl_close(_libNlSocket);
        //     LibnlPInvoke.nl_socket_free(_libNlSocket);
        //     throw new Exception("Failed to allocate netlink callback");
        // }
        //
        // LibnlPInvoke.nl_cb_set(
        //     _callBack1,
        //     LibnlPInvoke.nl_cb_type.NL_CB_VALID,
        //     LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
        //     getWifiName_callback, w);
        // LibnlPInvoke.nl_cb_set(
        //     _callBack1,
        //     LibnlPInvoke.nl_cb_type.NL_CB_FINISH,
        //     LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
        //     finish_handler,
        //     &(nl->result1));
        // LibnlPInvoke.nl_cb_set(
        //     _callBack1,
        //     LibnlPInvoke.nl_cb_type.NL_CB_VALID,
        //     LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
        //     getWifiInfo_callback,
        //     w);
        // LibnlPInvoke.nl_cb_set(
        //     _callBack2,
        //     LibnlPInvoke.nl_cb_type.NL_CB_FINISH,
        //     LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
        //     finish_handler,
        //     &(nl->result2));
    }
}