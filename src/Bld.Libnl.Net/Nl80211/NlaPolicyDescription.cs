namespace Bld.Libnl.Net.Nl80211;

public class NlaPolicyDescription
{
    public NlaPolicyDescription(NetlinkAttributeType type)
    {
        Type = type;
    }

    public NetlinkAttributeType Type { get; private set; }
}