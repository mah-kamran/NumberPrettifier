using System;
using System.Text.RegularExpressions;

public static class PerttifierClass
    {
        /// <summary>
        /// prettfies inoput per million , billion and trillions
        /// assumtions : 1. input number can only be positive (otherwise conditions 
        /// should be modified 2. returns null for values larger than trillion 3.for billion 
        /// and million and trillion always has a floating value (even if it is zero)
        /// </summary>
        /// <param name="input"> a double number</param>
        /// <returns> prettified version of number as a string</returns>
        public static string NumberPrettifier(double input)
        {
            string pattern = @"\d+(\.\d)?";
            var res = "";
            Regex regex = new(pattern);

            if (input < 100000)
                return input.ToString();

            else if (input >= 1000000 && input < 1000000000)
            {
                double devided = input / 1000000;
                var devided_str = devided.ToString();
                res = regex.Match(devided_str) + "M";
            }
            else if (input >= 1000000000 && input < 100000000000)
            {
                double devided = input / 1000000000;
                var devided_str = devided.ToString();
                res = regex.Match(devided_str) + "B";
            }
            else if (input > 100000000000)
                res = null;

            return res;
        }
    }

