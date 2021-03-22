using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TestEFC.Services
{
    public class HashService
    {
        public static string GetHashStr(string input, int iter_count)
        {
            var Rdgn = RandomNumberGenerator.Create();
            byte[] temparr = new byte[128];
            Rdgn.GetNonZeroBytes(temparr);
            byte[] temp = Encoding.ASCII.GetBytes(input);
            SHA512 sha512 = SHA512.Create();
            for (int i = 0; i < iter_count; i++)
            {
                var lx = sha512.ComputeHash(temp);

                var t_res = lx.ToList().Concat(temparr);
                temp = sha512.ComputeHash(t_res.ToArray());
            }
            return Convert.ToBase64String(temp);
        }
    }
}
