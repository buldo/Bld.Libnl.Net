namespace Bld.Libnl.Net.Netlink;

public enum IfMode
{
    Unspecified = 0,
    Ibss,
    Managed,
    Ap,
    ApVlan,
    Wds,
    Monitor,
    MeshPoint,
    P2pClient,
    P2pGO,
    P2pDevice,
    OutsideContextOfaBss,
    Nan
}