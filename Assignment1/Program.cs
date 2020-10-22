using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string firstNumber = "";
            int firstNumberInt;
            int secondNumberInt;
            string secondNumber = "";
            bool switchtosecond = false;
            Console.WriteLine("Enter numbers '123+456 :");
            input = Console.ReadLine();
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '+' && i > 0)
                    {
                        switchtosecond = true;
                    }
                    else
                    {
                        if (switchtosecond)
                        {
                            secondNumber += input[i].ToString();
                        }
                        else
                        {
                            firstNumber += input[i].ToString();
                        }
                    }
                }

                firstNumberInt = Int32.Parse(firstNumber);
                secondNumberInt = Int32.Parse(secondNumber);
                Console.WriteLine("result=" + (firstNumberInt + secondNumberInt));
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
        }
    }
}
