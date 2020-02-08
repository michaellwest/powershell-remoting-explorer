using System;
using System.Runtime.InteropServices;
using System.Security;

namespace PSRemotingExplorer.Extensions
{
    public static class StringExtensions
    {
        private static readonly byte[] Entropy = System.Text.Encoding.Unicode.GetBytes("Salt Is Not A Password");

        public static SecureString ToSecureString(this string source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var result = new SecureString();

            foreach (var character in source.ToCharArray()) result.AppendChar(character);

            result.MakeReadOnly();

            return result;
        }

        public static string ToPlainString(this SecureString value)
        {
            if (value == null) return null;

            var bstr = Marshal.SecureStringToBSTR(value);

            try
            {
                return Marshal.PtrToStringBSTR(bstr);
            }
            finally
            {
                Marshal.FreeBSTR(bstr);
            }
        }

        public static string EncryptString(this SecureString input)
        {
            var encryptedData = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ToPlainString(input)),
                Entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static SecureString DecryptString(this string encryptedData)
        {
            try
            {
                var decryptedData = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(encryptedData),
                    Entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ToSecureString(System.Text.Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }

        public static bool Is(this string value, string compare)
        {
            return string.Compare(value, compare, StringComparison.InvariantCultureIgnoreCase) == 0;
        }
    }
}