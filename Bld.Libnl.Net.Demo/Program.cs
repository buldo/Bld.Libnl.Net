// See https://aka.ms/new-console-template for more information

using Bld.Libnl.Net;

Console.WriteLine("Hello, World!");

var libnlWrapper = new Nl80211Wrapper();
var message = await libnlWrapper.ExecuteCommand();