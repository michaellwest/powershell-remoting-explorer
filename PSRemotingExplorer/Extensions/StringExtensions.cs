using System;
using System.Security;

namespace PSRemotingExplorer.Extensions
{
    public static class StringExtensions
    {
        public static SecureString ToSecureString(this string source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var result = new SecureString();

            foreach (var character in source.ToCharArray()) result.AppendChar(character);

            result.MakeReadOnly();

            return result;
        }

        public static bool Is(this string value, string compare)
        {
            return string.Compare(value, compare, StringComparison.InvariantCultureIgnoreCase) == 0;
        }
    }
}