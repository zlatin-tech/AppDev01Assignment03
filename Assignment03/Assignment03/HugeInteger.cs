using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{


    internal class HugeInteger
    {
        private string value;
        
        
        public HugeInteger(string value)
        {
            Value = value;
        }
        public string Value
        { 
            get { return value; }
            set
            {
                if (IsValidInteger(value))
                { 
                    value = RemoveLeadingZeros(value);
                    if (string.IsNullOrWhiteSpace(value) || value == "-")
                    {
                        value = "0";
                    }
                    this.value = value;
                }
            }
        }

        private static bool IsValidInteger(string input)
        {
            if (string.IsNullOrEmpty(input) || (input.Length == 1 && input[0] == '-'))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    if (i == 0 && input[i] == '-')
                        continue;

                    return false;
                }
            }
            return true;
        }

        private static string RemoveLeadingZeros(string input)
        {
            if (string.IsNullOrEmpty(input) || (input.Length == 1 && input[0] == '-'))
                return input;

            if (input[0] == '0')
                return RemoveLeadingZeros(input.Substring(1));

            if (input[0] == '-')
                return "-" + RemoveLeadingZeros(input.Substring(1));

            return input;
        }

        // PART I METHODS (Add method not implemented)
        public HugeInteger Add(HugeInteger number2)
        {
            string num1 = this.Value;
            string num2 = number2.Value;
            string answer = "";
            string negative = "";
            if (num1.Contains("-") && !num2.Contains("-"))
            {
                num1 = num1.Replace("-", "");
                return number2.Subtract(new HugeInteger(num1));
            }
            if (!num1.Contains("-") && num2.Contains("-"))
            {
                num2 = num2.Replace("-", "");
                return this.Subtract(new HugeInteger(num2));
            }
            if (num1.Contains("-") && num2.Contains("-"))
            {
                negative = "-";
                num1 = num1.Replace("-","");
                num2 = num2.Replace("-","");
            }
            int lengthDifference = Math.Abs(num1.Length - num2.Length);

            if (num1.Length > num2.Length)
            {
                string zeros = new string('0', lengthDifference);
                num2 = zeros + num2;
            }
            else if (num2.Length > num1.Length)
            {
                string zeros = new string('0', lengthDifference);
                num1 = zeros + num1;
            }
            //adding extra 0 in case of carry
            num1 = "0" + num1;
            num2 = "0" + num2;
            int a;
            int b = 0;
            int c = 0;
            int d = 0;//carry value
            
            for (int i = num1.Length -1;i >= 0 ;i--)
            { 
                 a = (int)num1[i] - '0';
                 b = (int)num2[i] - '0';
                 c = a + b + d;

                if (c >= 10)
                {
                    d = c / 10;
                    c = c % 10;
                }
                else
                {
                    d = 0;
                }
                answer = c.ToString() + answer;
            }
            
            answer = negative + answer;
            
            return new HugeInteger(answer);
        }
        public HugeInteger Subtract(HugeInteger number2)
        {
            string num1 = this.Value;
            string num2 = number2.Value;
            string answer = "";
            string negative = "";

            // Handle cases with negative numbers
            if (num1.Contains("-") && !num2.Contains("-"))
            {
                return this.Add(new HugeInteger("-" + number2.Value));

            }
            if (!num1.Contains("-") && num2.Contains("-"))
            {
                num2 = num2.Replace("-", "");
                return this.Add(new HugeInteger(num2));
            }
            if (num1.Contains("-") && num2.Contains("-"))
            {
                num2 = num2.Replace("-", "");
                return new HugeInteger(num2).Add(this);
            }

            // Make sure num1 is greater than or equal to num2
            if (string.Compare(num1, num2) < 0)
            {
                string temp = num1;
                num1 = num2;
                num2 = temp;
                negative = "-";
            }

            int lengthDifference = Math.Abs(num1.Length - num2.Length);

            if (num1.Length > num2.Length)
            {
                string zeros = new string('0', lengthDifference);
                num2 = zeros + num2;
            }
            else if (num2.Length > num1.Length)
            {
                string zeros = new string('0', lengthDifference);
                num1 = zeros + num1;
            }

            // adding extra 0 in case of borrow
            num1 = "0" + num1;
            num2 = "0" + num2;

            int a;
            int b = 0;
            int c = 0;
            int borrow = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                a = (int)num1[i] - '0';
                b = (int)num2[i] - '0';
                c = a - b - borrow;

                if (c < 0)
                {
                    borrow = 1;
                    c = 10 + c;
                }
                else
                {
                    borrow = 0;
                }
                answer = c.ToString() + answer;
            }

            // Remove leading zeros
            answer = answer.TrimStart('0');

            if (string.IsNullOrEmpty(answer))
            {
                return new HugeInteger("0");
            }

            answer = negative + answer;

            return new HugeInteger(answer);
        }

        public HugeInteger Multiply(HugeInteger number2)
        {
            bool isNegativeResult = this.Value.StartsWith("-") ^ number2.Value.StartsWith("-");

            HugeInteger result = new HugeInteger("0");

            string num1 = this.Value.Replace("-", "");
            string num2 = number2.Value.Replace("-", "");

            num2 = new string(num2.Reverse().ToArray());

            for (int i = 0; i < num2.Length; i++)
            {
                int digit = num2[i] - '0';
                HugeInteger temp = new HugeInteger("0");

                for (int j = 0; j < digit; j++)
                {
                    temp = temp.Add(new HugeInteger(num1));
                }

                temp = new HugeInteger(temp.Value + new string('0', i));

                result = result.Add(temp);
            }

            if (isNegativeResult)
            {
                result = new HugeInteger("-" + result.Value.TrimStart('0'));
            }
            else
            {
                result = new HugeInteger(result.Value.TrimStart('0'));
            }

            if (result.Value == "" || result.Value == "-")
            {
                return new HugeInteger("0");
            }

            return result;
        }






        public HugeInteger Divide(HugeInteger number2)
        {
            if (number2.IsZero())
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            HugeInteger count = new HugeInteger("0");
            HugeInteger one = new HugeInteger("1");
            HugeInteger product = new HugeInteger("0");

            bool isNegativeResult = this.Value.StartsWith("-") ^ number2.Value.StartsWith("-");

            HugeInteger num1 = new HugeInteger(this.Value.Replace("-", ""));
            HugeInteger num2 = new HugeInteger(number2.Value.Replace("-", ""));

            while (product.IsLessThanOrEqualTo(num1))
            {
                count = count.Add(one);
                product = num2.Multiply(count);
            }

            // The loop goes one step too far, subtract one from the count
            count = count.Subtract(one);

            if (isNegativeResult)
            {
                count = new HugeInteger("-" + count.Value);
            }

            return count;
        }


        public HugeInteger Remainder(HugeInteger number2) 
        {
            HugeInteger result = this.Divide(number2);
            result = result.Multiply(number2);
            result = this.Subtract(result);
            return result;
        }

        public override string ToString()
        {
            string val = Value;
            string output = "";
            bool isNegative = false;

            if (val[0] == '-')
            {
                isNegative = true;
                val = val.Substring(1); // Remove the negative sign TEMPORARILY
            }

            for (int i = 0; i < val.Length; i++)
            {
                if (i > 0 && (val.Length - i) % 3 == 0)
                {
                    output += " ";
                }
                output += val[i];
            }

            if (isNegative)
            {
                output = "-" + output;
            }

            return output;
        }


        public bool IsZero()
        {
            string n = this.Value;
            return n[0] == '0' || (n.Length > 1 && n[0] == '-' && n[1] == '0');
        }

        // PART II: COMPARING HUGE INTEGERS METHODS
        public bool IsEqualTo(HugeInteger number2)
        {
            string value = this.value, value2 = number2.Value;
            return value.Equals(value2);
        }

        public bool IsNotEqualTo(HugeInteger number2)
        {
            return !IsEqualTo(number2);
        }

        public bool IsGreaterThan(HugeInteger number2)
        {
            string value = this.value, value2 = number2.Value;

            if (!value.Contains("-") && value2.Contains("-"))
            {
                return true;
            }
            if (value.Contains("-") && !value2.Contains("-"))
            {
                return false;
            }

            bool arePositive = value[0] != '-';

            if (arePositive)
            {
                if (value.Length > value2.Length)
                {
                    return true;
                }
                if (value.Length < value2.Length)
                {
                    return false;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > value2[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (value.Length > value2.Length)
                {
                    return false;
                }
                if (value.Length < value2.Length)
                {
                    return true;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < value2[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsLessThan(HugeInteger number2)
        {
            string value = this.value, value2 = number2.Value;
            if (!value.Contains("-") && value2.Contains("-"))
            {
                return false;
            }
            if (value.Contains("-") && !value2.Contains("-"))
            {
                return true;
            }

            bool arePositive = value[0] != '-';
            if (arePositive)
            {
                if (value.Length > value2.Length)
                {
                    return false;
                }
                if (value.Length < value2.Length)
                {
                    return true;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < value2[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (value.Length > value2.Length)
                {
                    return true;
                }
                if (value.Length < value2.Length)
                {
                    return false;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > value2[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsGreaterThanOrEqualTo(HugeInteger number2)
        {
            return IsGreaterThan(number2) || IsEqualTo(number2);
        }

        public bool IsLessThanOrEqualTo(HugeInteger number2)
        {
            return IsLessThan(number2) || IsEqualTo(number2);
        }
    }

}
