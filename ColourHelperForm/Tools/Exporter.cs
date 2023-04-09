using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ColourHelperForm.Tools {
    public class Exporter {
        public static List<string> ToJson(Dictionary<string, double> dictionary) {
            var entries = dictionary.Select(entry => $"\"{entry.Key}\": \"{Math.Round(entry.Value, 2)}ml\"");
            return new List<string>() { "{ " + string.Join(", ", entries) + " }" };
        }

        public static List<string> ToText(Dictionary<string, double> dictionary) {
            List<string> content = new();

            foreach (var entry in dictionary) {
                content.Add(string.Format($"{entry.Key}: {Math.Round(entry.Value, 2)}ml"));
            }

            return content;
        }
    }
}