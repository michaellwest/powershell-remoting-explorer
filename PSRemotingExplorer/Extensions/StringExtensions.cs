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
    }
}