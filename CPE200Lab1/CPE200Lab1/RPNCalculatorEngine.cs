using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            string firstoperand;
            string secondoperand;
            string[] parts = str.Split(' ');
            string temp ;
            int i = 0;
            Stack<string> numbers = new Stack<string>();
            for ( i = 0; i < parts.Length; i++)
            {
                if (isNumber(parts[i]) == true)
                {
                    numbers.Push(parts[i]);

                }
                if (isOperator(parts[i])==true)
                {

                    if (numbers.Count < 2)
                    {
                        return "E";
                    }
                    else
                  {
                        try
                        {
                            secondoperand = numbers.Pop();
                            firstoperand = numbers.Pop();
                            
                            temp = calculate(parts[i], firstoperand, secondoperand);
                            numbers.Push(temp);
                        } catch(Exception ex)
                        {
                            return "WRONGGGGGG";
                        }

                    } 

                }
            }
            // your code here
            if (numbers.Count == 1)
            {
                return numbers.Pop();
            }
            else return "E";
        }
    }
}
