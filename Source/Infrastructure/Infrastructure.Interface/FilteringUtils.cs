#region Usings

using System.Collections.Generic;

#endregion

namespace Naro.Infrastructure.Interface
{
    public static class FilteringUtils
    {
        public static bool PassFiltering(string text, IEnumerable<string> filterTokens)
        {
            foreach (var token in filterTokens)
            {
                if (text.IndexOf(token) == -1)
                    return false;
            }
            return true;
        }

        public static bool PassFilteringInsensitive(string text, IEnumerable<string> filterTokens)
        {
            var upperText = text.ToUpper();
            foreach (var token in filterTokens)
            {
                if (upperText.IndexOf(token.ToUpper()) == -1)
                    return false;
            }
            return true;
        }
    }
}