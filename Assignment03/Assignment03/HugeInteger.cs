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
            SetValue(value);
        }

        public void SetValue(string value)
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

        public string GetValue()
        {
            return value;
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
            string num1 = this.ToString();
            string num2 = number2.ToString();
            string answer = "";
            string negative = "";
            if (num1.Contains("-") && !num2.Contains("-"))
            {
                return number2.Substract(this);
            }
            if (!num1.Contains("-") && num2.Contains("-"))
            {
                return number2.Substract(this);
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
            for (int i = num1.Length; ;)
            { 
                
            }
            answer = negative + answer;
            
            return new HugeInteger(answer);
        }
        public HugeInteger Substract(HugeInteger number2)
        {
            return null;
        }
        public HugeInteger Multiply(HugeInteger number2)
        {
            return null;
        }
        public HugeInteger Divide(HugeInteger number2)
        {
            return null;
        }
        public HugeInteger Remainder(HugeInteger number2) 
        {
            return null;
        }

        public override string ToString()
        {
            return value;
        }

        public bool IsZero()
        {
            string n = this.ToString();
            return n[0] == '0' || (n.Length > 1 && n[0] == '-' && n[1] == '0');
        }

        // PART II: COMPARING HUGE INTEGERS METHODS
        public bool IsEqualTo(HugeInteger number2)
        {
            string value = this.value, value2 = number2.GetValue();
            return value.Equals(value2);
        }

        public bool IsNotEqualTo(HugeInteger number2)
        {
            return !IsEqualTo(number2);
        }

        public bool IsGreaterThan(HugeInteger number2)
        {
            string value = this.value, value2 = number2.GetValue();

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
            string value = this.value, value2 = number2.GetValue();
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
