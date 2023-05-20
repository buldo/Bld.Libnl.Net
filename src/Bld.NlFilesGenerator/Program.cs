// See https://aka.ms/new-console-template for more information
// nl80211 files is from linux-6.3.1
// This application is very-very limited source generator
// It generates C# enum and message descriptions from linux kernel sources

using Bld.NlFilesGenerator;

Console.WriteLine("Hello, World!");

//var nlEnumGenerator = new NlEnumGenerator("sources/nl80211.h", "../../../../Bld.Libnl.Net/Nl80211/Enums");
//nlEnumGenerator.Generate();

var nlPolicyGenerator = new NlPolicyGenerator("sources/nl80211.c", "../../../../Bld.Libnl.Net/Nl80211/Policies");
//var nlPolicyGenerator = new NlPolicyGenerator("sources/nl80211.c", "Policies");
nlPolicyGenerator.Generate();