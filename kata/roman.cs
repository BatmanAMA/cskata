using System;

namespace kata
{
    public class Roman 
    {
        public static String toRoman(int number) 
        {
            string roman = new String('I',number);
            return roman.
                Replace("IIIII","V"). //standard 
                Replace("VV","X").    //10
                Replace("XXXXX","L"). //50
                Replace("LL","C").    //100
                Replace("CCCCC","D"). //500
                Replace("DD","M").    //1000
                //now remove 4 repeats with the alternate
                Replace("IIII","IV").
                Replace("XXXXV","VL").
                Replace("XXXX","XL").
                Replace("CCCCL","LD").
                Replace("CCCC","CD").
                //clean up some wierd ones
                Replace("DLD","CML").
                Replace("LXL", "XC").
                Replace("LVL", "VC").
                Replace("LIL","IC").
                Replace("VIV","IX").
                Replace("DCD","CM");
        }
        public static int fromRoman(string text)
        {
            int last = 10000;
            int total = 0;
            foreach (char c in text.ToCharArray()) 
            {
                int digit = 0;
                switch (c)
                {
                    case 'I':
                        digit = 1;
                        break;
                    case 'V':
                        digit = 5;
                        break;
                    case 'X':
                        digit = 10;
                        break;
                    case 'L':
                        digit = 50;
                        break;
                    case 'C':
                        digit = 100;
                        break;
                    case 'D':
                        digit = 500;
                        break;
                    case 'M':
                        digit = 1000;
                        break;
                }
                if (last < digit)
                {
                    total = total - last + digit - last;
                    last = digit;
                }
                else
                {
                    last = digit;
                    total += digit;
                }
            }
            return total;
        }
    }
}
