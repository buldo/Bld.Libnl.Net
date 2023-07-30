namespace Bld.Libnl.Net.Netlink;

internal static class IfModes
{
    public static readonly string[] ifmodes = {
        "unspecified",
        "IBSS",
        "managed",
        "AP",
        "AP/VLAN",
        "WDS",
        "monitor",
        "mesh point",
        "P2P-client",
        "P2P-GO",
        "P2P-device",
        "outside context of a BSS",
        "NAN",
    };
}