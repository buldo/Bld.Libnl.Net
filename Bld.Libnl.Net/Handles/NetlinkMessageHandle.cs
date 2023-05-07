using System.Runtime.InteropServices;
using static Bld.Libnl.Net.LibnlPInvoke;

namespace Bld.Libnl.Net.Handles;

public class NetlinkMessageHandle : SafeHandle
{
    public NetlinkMessageHandle() : base(IntPtr.Zero, true)
    {
    }

    protected override bool ReleaseHandle()
    {
        nlmsg_free(handle);
        return true;
    }

    public override bool IsInvalid => handle == IntPtr.Zero;
}