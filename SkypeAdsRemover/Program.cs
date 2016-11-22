using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Redmanmale.SkypeAdsRemover
{
    internal static class Program
    {
        private const string configFilename = "config.xml";

        private const string adPattern = "<AdvertPlaceholder>1</AdvertPlaceholder>";
        private const string adDisabledPattern = "<AdvertPlaceholder>0</AdvertPlaceholder>";

        private static readonly Regex _finder = new Regex(adPattern, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

        private static void Main(string[] args)
        {
            if (args == null || args.Length == 0 || string.IsNullOrWhiteSpace(args[0]))
            {
                Console.WriteLine("Provide skype profile in argument");
                return;
            }

            var userName = args[0];

            var filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Skype", userName, configFilename);
            if (!File.Exists(filepath))
            {
                return;
            }

            try
            {
                var skypeConfig = File.ReadAllText(filepath, Encoding.ASCII);
                var match = _finder.Match(skypeConfig);
                if (match.Success)
                {
                    var result = _finder.Replace(skypeConfig, adDisabledPattern);
                    File.WriteAllText(filepath, result, Encoding.ASCII);
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
