using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var parts = numbers.Split(',');
            var sum = 0;

            foreach (var part in parts)
            {
                if (!int.TryParse(part, out var number))
                {
                    throw new FormatException($"Invalid input: '{part}' is not a valid number.");
                }
                sum += int.Parse(part);
            }

            return sum;
        }
    }
}
