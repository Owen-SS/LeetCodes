internal class RomanToIntClassBase
{
    public static int RomanToInt(string s)
    {
        int number = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case 'I':
                    number += 1;
                    break;
                case 'V':
                    number += 5;
                    break;
                case 'X':
                    number += 10;
                    break;
                case 'L':
                    number += 50;
                    break;
                case 'C':
                    number += 100;
                    break;
                case 'D':
                    number += 500;
                    break;
                case 'M':
                    number += 1000;
                    break;
            }
        }

        if (s.Contains("IV")) number -= 2;
        if (s.Contains("IX")) number -= 2;
        if (s.Contains("XL")) number -= 20;
        if (s.Contains("XC")) number -= 20;
        if (s.Contains("CD")) number -= 200;
        if (s.Contains("CM")) number -= 200;

        return number;
    }
}