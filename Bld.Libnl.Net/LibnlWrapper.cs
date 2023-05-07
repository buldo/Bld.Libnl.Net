using System.Net.Sockets;

namespace Bld.Libnl.Net;

public class LibnlWrapper
{
    private readonly Nl80211State _state;
    
    private readonly IntPtr _callBack1;
    private readonly IntPtr _callBack2;
    
    public LibnlWrapper()
    {
        
        var libNlSocket = LibnlPInvoke.nl_socket_alloc();
        if (libNlSocket == IntPtr.Zero)
        {
            throw new Exception("Failed to allocate netlink socket");
        }

        LibnlPInvoke.nl_socket_set_buffer_size(libNlSocket, 8192, 8192);

        var connectResult = LibnlGenlPInvoke.genl_connect(libNlSocket);
        if (connectResult != 0)
        {
            LibnlPInvoke.nl_close(libNlSocket);
            LibnlPInvoke.nl_socket_free(libNlSocket);
            throw new Exception($"genl_connect error. Result: {connectResult}");
        }

        var familyIdentifier = LibnlGenlPInvoke.genl_ctrl_resolve(libNlSocket, "nl80211");
        if (familyIdentifier < 0) 
        {
            LibnlPInvoke.nl_close(libNlSocket);
            LibnlPInvoke.nl_socket_free(libNlSocket);
            throw new Exception("Nl80211 interface not found");
        }

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