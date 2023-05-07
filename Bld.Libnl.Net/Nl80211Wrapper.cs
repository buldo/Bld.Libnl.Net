using Bld.Libnl.Net.Handles;

namespace Bld.Libnl.Net;

public class CallbackBasedCommand : IDisposable
{
    private readonly Nl80211State _state;
    private readonly CallbackHandle _callBackHandle;
    private readonly NetlinkMessageHandle _messageHandle;

    internal CallbackBasedCommand(Nl80211State state)
    {
        _state = state;
        _callBackHandle = LibnlPInvoke.nl_cb_alloc(LibnlPInvoke.nl_cb_kind.NL_CB_DEFAULT);
        if (_callBackHandle.IsInvalid)
        {
            throw new Exception("Failed to allocate netlink callback");
        }

        _callBackHandle.Set(LibnlPInvoke.nl_cb_type.NL_CB_VALID, LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM, Func1, IntPtr.Zero);
        _callBackHandle.Set(LibnlPInvoke.nl_cb_type.NL_CB_VALID, LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM, Func2, IntPtr.Zero);


        _messageHandle = LibnlPInvoke.nlmsg_alloc();
        if (_messageHandle.IsInvalid)
        {
            throw new Exception("Failed to allocate nl message");
        }
    }

    public void PutMessage(MessageFlags flags, byte cmd)
    {
        _messageHandle.Put(
            LibnlPInvoke.NL_AUTO_PORT,
            LibnlPInvoke.NL_AUTO_SEQ,
            _state.FamilyIdentifier,
            0,
            flags,
            cmd,
            0);
    }

    private int Func2(IntPtr msg, IntPtr arg)
    {
        throw new NotImplementedException();
    }

    private int Func1(IntPtr msg, IntPtr arg)
    {
        throw new NotImplementedException();
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            _callBackHandle.Dispose();
            _messageHandle.Dispose();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~CallbackBasedCommand()
    {
        Dispose(false);
    }
}

public class Nl80211Wrapper
{
    private readonly Nl80211State _state;
    public Nl80211Wrapper()
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
    }

    public async Task ExecuteCommand()
    {
        using var callbackCommand = new CallbackBasedCommand(_state);
        callbackCommand.PutMessage(MessageFlags.NLM_F_DUMP, (byte)Nl80211Command.NL80211_CMD_GET_INTERFACE);
    }
}