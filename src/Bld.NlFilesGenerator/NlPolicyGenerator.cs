namespace Bld.NlFilesGenerator;

internal class NlPolicyGenerator
{
    private readonly string _fileName;
    private readonly string _outDir;

    public NlPolicyGenerator(string fileName, string outDir)
    {
        _fileName = fileName;
        _outDir = outDir;

        if (Directory.Exists(_outDir))
        {
            Directory.Delete(_outDir, true);
        }

        Directory.CreateDirectory(_outDir);
    }

    public void Generate()
    {
        var fileStrings = File.ReadAllLines(_fileName);
        Console.WriteLine($"{_fileName}: {fileStrings.Length}");

        var policies = new Dictionary<string,PolicyModel>();

        for (int i = 0; i < fileStrings.Length; i++)
        {
            var currentLine = fileStrings[i];
            if (!(currentLine.StartsWith("static const struct nla_policy") && !currentLine.EndsWith(";")))
            {
                continue;
            }

            if (!currentLine.Contains('['))
            {
                i++;
                currentLine = fileStrings[i];
            }

            string name = null;
            var currentSplit = currentLine.Split('[');
            if (currentSplit[0].Contains(' '))
            {
                name = currentSplit[0].Split(' ').Last().Trim();
            }
            else
            {
                name = currentSplit[0].Trim();
            }

            var model = new PolicyModel { Name = name };
            policies[name] = model;

            do
            {
                currentLine = fileStrings[i];
                model.EnumString.Add(currentLine);
                i++;
            } while (!currentLine.Trim().EndsWith("};"));
        }


        foreach (var (_, policyModel) in policies)
        {
            var fileName = Path.Combine(_outDir, $"{policyModel.Name}.txt");
            File.AppendAllLines(fileName, new[]
            {
                "using Bld.Libnl.Net.Nl80211.Enums;",
                "",
                "namespace Bld.Libnl.Net.Nl80211.Enums;",
                "",
                "public static partial class NlaPolicies",
                "{"
            });

            policyModel.EnumString[0] = $"public static Dictionary<string, string> {policyModel.EnumString[0]}";

            File.AppendAllLines(fileName, policyModel.EnumString);

            File.AppendAllLines(fileName, new[]
            {
                "}"
            });
        }
    }

    private class PolicyModel
    {
        public string Name { get; set; }

        public List<string> EnumString { get; } = new();
    }
}