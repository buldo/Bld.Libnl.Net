using Bld.Libnl.Net.Handles;

namespace Bld.Libnl.Net;

internal class Nl80211State
{
    public required LibNlSocketHandle LibNlSocket { get; internal init; }
    public required int FamilyIdentifier { get; internal init; }
}