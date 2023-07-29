// See https://aka.ms/new-console-template for more information

using Bld.Libnl.Net;
using Bld.Libnl.Net.Nl80211;
using Bld.Libnl.Net.Nl80211.Enums;

Console.WriteLine("Hello, World!");

var libnlWrapper = new Nl80211Wrapper();
//var phys = libnlWrapper.DumpWiphy();
var ifaces = libnlWrapper.DumpInterfaces();

foreach (var iface in ifaces)
{
    var name = (string)iface.Attributes[nl80211_attrs.NL80211_ATTR_IFNAME].GetValue();
    var wiPhy = (UInt32)iface.Attributes[nl80211_attrs.NL80211_ATTR_WIPHY].GetValue();
    Console.WriteLine($"{name} {wiPhy}");
}
