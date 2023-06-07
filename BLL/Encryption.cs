using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    public static class Encryption
    {
        public static string MyEncrypt(string input)
        {
            char[] char_input = input.ToCharArray(); //Chuyển input(string) sang mảng có kiểu char
            var pt = char_input.Select((value, index) => new { value, index }).ToArray();
            //char_input[i] + index(char_input[i]) + char_input[i+1]%2
            var ptnew = pt.Select(p => p.value + p.index + (pt.Length > p.index + 1 ? (pt[p.index + 1].value % 2) : 0)).Select(p => (char)p).ToArray();
            string result = new string(ptnew);
            return result;


        }
        public static string MyDecrupt(string input)
        {
            char[] temp = input.ToCharArray();
            int l = temp.Length;
            for (int i = l - 1; i >= 0; i--)
            {
                temp[i] = (char)(temp[i] - i - (i == l - 1 ? 0 : temp[i + 1] % 2));
            }

            string result = new string(temp);
            return result;
        }
    }
}
