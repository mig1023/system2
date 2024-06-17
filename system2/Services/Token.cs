using System.Security.Cryptography;

namespace system2.Services
{
    public class Token : IToken
    {
        public string Generate()
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            int length = 64;
            string charSet = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
                result[i] = charSet[RandomNumberGenerator.GetInt32(charSet.Length)];

            return new string(result);
        }
    }
}
