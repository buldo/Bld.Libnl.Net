using System.Runtime.InteropServices;
using static Bld.Libnl.Net.LibnlPInvoke;
using static Bld.Libnl.Net.LibnlGenlPInvoke;

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

    /// <summary>
    /// Add Generic Netlink headers to Netlink message
    /// </summary>
    public IntPtr Put(UInt32 port, UInt32 seq, int family, int hdrlen, MessageFlags flags, byte cmd, byte version)
    {
        var header = genlmsg_put(handle, port, seq, family, hdrlen, flags, cmd, version);
        if (header == IntPtr.Zero)
        {
            throw new Exception("genlmsg_put error");
        }

        return header;
    }
}