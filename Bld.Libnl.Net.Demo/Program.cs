// See https://aka.ms/new-console-template for more information

using Bld.Libnl.Net;
using Bld.Libnl.Net.Nl80211;

Console.WriteLine("Hello, World!");

var libnlWrapper = new Nl80211Wrapper();
libnlWrapper.SendMessage(MessageFlags.NLM_F_DUMP, Nl80211Command.NL80211_CMD_GET_WIPHY);