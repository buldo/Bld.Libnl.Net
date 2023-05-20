// See https://aka.ms/new-console-template for more information

using Bld.Libnl.Net;
using Bld.Libnl.Net.Nl80211;

Console.WriteLine("Hello, World!");

var libnlWrapper = new Nl80211Wrapper();
//var phys = libnlWrapper.DumpWiphy();
var ifaces = libnlWrapper.DumpInterfaces();
