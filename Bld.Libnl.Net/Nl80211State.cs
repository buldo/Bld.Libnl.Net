namespace Bld.Libnl.Net;

internal class Nl80211State
{
    public required LibNlSocketHandle LibNlSocket { get; init; }
    public required int FamilyIdentifier { get; init; }
}