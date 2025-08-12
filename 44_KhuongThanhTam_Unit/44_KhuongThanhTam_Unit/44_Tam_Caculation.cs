using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_KhuongThanhTam_Unit
{
    public class _44_Tam_Caculation
    {
        private int BinaryToDecimal(string binary)
        {
            int decimalNumber = 0;
            int length = binary.Length;
            for (int i = 0; i < length; ++i)
            {
                if (binary[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, length - i - 1);
                }
            }
            return decimalNumber;
        }

        private string DecimalToBinary(int decimalNumber)
        {
            string binary = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binary = remainder.ToString() + binary;
                decimalNumber /= 2;
            }
            return binary;
        }

        public int Chon(string operation, string binary, int decimalNumber)
        {
            int result = 0;
            switch (operation)
            {
                case "BinaryToDecimal":
                    result = BinaryToDecimal(binary);
                    break;
                case "DecimalToBinary":
                    result = int.Parse(DecimalToBinary(decimalNumber));
                    break;
                    
            }
            return result;
        }
    }
}
