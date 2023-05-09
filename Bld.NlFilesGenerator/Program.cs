// See https://aka.ms/new-console-template for more information
// nl80211 files is from linux-6.3.1
// This application is very-very limited source generator
// It generates C# enum and message descriptions from linux kernel sources
Console.WriteLine("Hello, World!");

var nlEnumGenerator = new NlEnumGenerator("sources/nl80211.h", "../../../../Bld.Libnl.Net/Nl80211/Enums");
nlEnumGenerator.Generate();

internal class NlEnumGenerator
{
    private readonly string _fileName;
    private readonly string _outDir;

    public NlEnumGenerator(string fileName, string outDir)
    {
        _fileName = fileName;
        _outDir = outDir;

        if (Directory.Exists(_outDir))
        {
            Directory.Delete(_outDir);
        }

        Directory.CreateDirectory(_outDir);
    }

    public void Generate()
    {
        var fileStrings = File.ReadAllLines(_fileName);
        Console.WriteLine($"{_fileName}: {fileStrings.Length}");

        var enums = new Dictionary<string,EnumModel>();

        for (int i = 0; i < fileStrings.Length; i++)
        {
            var currentLine = fileStrings[i];
            if (!currentLine.StartsWith("enum"))
            {
                continue;
            }

            var currentSplit = currentLine.Split(' ');
            var enumName = currentSplit[1];
            var enumModel = new EnumModel { Name = enumName };
            enums[enumName] = enumModel;

            do
            {
                currentLine = fileStrings[i];
                enumModel.EnumString.Add(currentLine);
                i++;
            } while (!currentLine.Trim().EndsWith("};"));
        }


        foreach (var (_, enumModel) in enums)
        {
            var fileName = Path.Combine(_outDir, $"{enumModel.Name}.cs");
            File.AppendAllLines(fileName, new []{ "namespace Bld.Libnl.Net.Nl80211.Enums;", "" });

            enumModel.EnumString[0] = $"public {enumModel.EnumString[0]}";

            File.AppendAllLines(fileName, enumModel.EnumString);
        }
    }

    private class EnumModel
    {
        public string Name { get; set; }

        public List<string> EnumString { get; } = new();
    }
}