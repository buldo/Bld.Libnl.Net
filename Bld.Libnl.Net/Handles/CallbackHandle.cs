using System.Runtime.InteropServices;
using static Bld.Libnl.Net.LibnlPInvoke;

namespace Bld.Libnl.Net.Handles;

public class CallbackHandle : SafeHandle
{
    public CallbackHandle() : base(IntPtr.Zero, true)
    {
    }

    protected override bool ReleaseHandle()
    {
        return true;
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    public void Set(nl_cb_type type, nl_cb_kind kind, nl_recvmsg_msg_cb_t func, IntPtr arg)
    {
        nl_cb_set(handle, type, kind, func, arg);
    }
}