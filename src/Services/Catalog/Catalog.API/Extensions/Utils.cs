using System.Text.RegularExpressions;

namespace Catalog.API.Extensions
{
    public static class Utils
    {
        public static string ToMostlyEqual(this string s)
        {
            string[] groups = s.Split(
                       new[] { '-', ' ' },
                       StringSplitOptions.RemoveEmptyEntries
                  );
            string str = string.Join("-", groups).ToLower();
            Regex rgx = new Regex("[^a-zA-Z0-9-]");
            return rgx.Replace(str, "");
        }
    }
}
