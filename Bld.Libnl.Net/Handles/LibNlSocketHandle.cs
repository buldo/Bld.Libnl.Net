using System.Runtime.InteropServices;
using static Bld.Libnl.Net.LibnlPInvoke;

namespace Bld.Libnl.Net.Handles;

public class LibNlSocketHandle : SafeHandle
{
    public LibNlSocketHandle() : base(IntPtr.Zero, true)
    {
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    public void SetBufferSize(int rxBufSize, int txBufSize)
    {
        nl_socket_set_buffer_size(handle, rxBufSize, txBufSize);
    }

    public void Connect()
    {
        var connectResult = LibnlGenlPInvoke.genl_connect(handle);
        if (connectResult != 0)
        {
            throw new Exception($"genl_connect error. Result: {connectResult}");
        }
    }

    public int CtrlResolve(string name)
    {
        var familyIdentifier = LibnlGenlPInvoke.genl_ctrl_resolve(handle, name);
        if (familyIdentifier < 0)
        {
            throw new Exception("Nl80211 interface not found");
        }

        return familyIdentifier;
    }

    public void RecvMsgsDefault()
    {
        LibnlPInvoke.nl_recvmsgs_default(handle);
    }

    public void SendAuto(NetlinkMessageHandle msg)
    {
        var sentBytes = nl_send_auto(handle, msg.DangerousGetHandle());
        if (sentBytes < 0)
        {
            throw new Exception($"nl_send_auto error: {sentBytes}");
        }
    }

    public void ModifyCallback(
        nl_cb_type type,
        nl_cb_kind kind,
        nl_recvmsg_msg_cb_t func,
        IntPtr arg)
    {
        var modResult = nl_socket_modify_cb(handle, type, kind, func, arg);
        if (modResult < 0)
        {
            throw new Exception($"nl_socket_modify_cb error: {modResult}");
        }
    }

    protected override bool ReleaseHandle()
    {
        nl_close(handle);
        nl_socket_free(handle);
        return true;
    }
}