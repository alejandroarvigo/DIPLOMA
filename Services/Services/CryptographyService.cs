using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Services.Services
{
    public static class CryptographyService
    {
        public static string HashPassword(string textPlainPass)
        {
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] retVal = md5.ComputeHash(Encoding.Unicode.GetBytes(textPlainPass));
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
            }
            return sb.ToString();
        }

        public static decimal DVHCalculate(string message)
        {
            byte[] hashValue;
            UTF8Encoding ue = new UTF8Encoding();

            byte[] messageBytes = ue.GetBytes(message);
            SHA256 shHash = SHA256.Create();

            hashValue = shHash.ComputeHash(messageBytes);

            decimal valor = hashValue.Sum(o => o);
            return valor;

        }
    }
}
