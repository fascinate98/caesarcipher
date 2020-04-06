using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Decrypt
    {
        public static string Decryption(string crypto, int key)
        {
            key %= 26;
            string result = "";
            char[] value = crypto.ToCharArray();

            for (int i = 0; i < crypto.Length; i++)
            {
                if (Char.IsUpper(value[i]))
                {
                    value[i] = (char)((value[i] - 'Z' - key) % 26 + 'Z');
                }
                else if (Char.IsLower(value[i]))
                {
                    value[i] = (char)((value[i] - 'z' - key) % 26 + 'z');
                }
                else if (value[i] == ' ')
                {
                    value[i] = ' ';
                }
                else
                {
                    result = "입력값이 잘못되었습니다. 알파벳만 입력해주세요.";
                    return result;
                }
            }
            result = string.Concat(value);

            return result;
        }
    }
}
