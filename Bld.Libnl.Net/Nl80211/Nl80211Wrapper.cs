﻿using Bld.Libnl.Net.Handles;
using Bld.Libnl.Net.Netlink;
using static Bld.Libnl.Net.LibnlPInvoke;
using static Bld.Libnl.Net.LibnlGenlPInvoke;

namespace Bld.Libnl.Net.Nl80211;

/// <summary>
/// Methods not re-enterable
/// </summary>
public class Nl80211Wrapper
{
    private readonly LibNlSocketHandle _libNlSocket;
    private readonly int _familyIdentifier;

    private bool _isCurrentCommandRunning = false;

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

        _libNlSocket.ModifyCallback(
            LibnlPInvoke.nl_cb_type.NL_CB_FINISH,
            LibnlPInvoke.nl_cb_kind.NL_CB_CUSTOM,
            FinishSocketCallback,
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

        _isCurrentCommandRunning = true;
        while (_isCurrentCommandRunning)
        {
            _libNlSocket.RecvMsgsDefault();
        }
    }

    private int SocketCallback(IntPtr msg, IntPtr arg)
    {
        var message = NetlinkMessageParser.Parse<Nl80211Attrs>(msg);

        foreach (var attribute in message.Attributes)
        {
            Console.WriteLine($"{attribute.Id} : {attribute.GetValue()}");
        }
        Console.WriteLine("Received");
        //Console.WriteLine($"Name: {wiPhy.WiphyName}; Id:{wiPhy.Wiphy}");
        return (int)nl_cb_action.NL_SKIP;
    }

    private int FinishSocketCallback(IntPtr msg, IntPtr arg)
    {
        _isCurrentCommandRunning = false;
        Console.WriteLine("Finish");
        return (int)nl_cb_action.NL_SKIP;
    }

    public List<WiphyMessage> DumpWiphy()
    {
        SendMessage(MessageFlags.NLM_F_DUMP, Nl80211Command.NL80211_CMD_GET_WIPHY);
        return new List<WiphyMessage>();
    }
}