using System.Runtime.CompilerServices;

namespace Challenge4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string of  '(', ')', '{', '}', '[' and ']' for program to determine if string is valid");
            string userInput=Console.ReadLine();
            compareString(userInput);


            void compareString(string userInput){

                if (userInput == null || userInput.Length % 2 != 0)
                {
                    Console.WriteLine("Invalid String");
                    return;
                }

                for (int i = 0; i < userInput.Length; i = i + 2)
                {
                    if (userInput[i] != '{' && userInput[i] != '[' && userInput[i] != '(')
                    {
                        Console.WriteLine("Invalid String");
                        return ;
                    }
                    if (userInput[i] == '{' && userInput[i+1] != '}')
                    {
                        Console.WriteLine("Invalid String");
                        return;

                    }
                    if (userInput[i] == '[' && userInput[i + 1] != ']')
                    {
                        Console.WriteLine("Invalid String");
                        return;
                    }
                    if (userInput[i] == '(' && userInput[i + 1] != ')')
                    {
                        Console.WriteLine("Invalid String");
                        return;
                    }


                }
                Console.WriteLine("Valid String");
                return;

            }
        }
    }
}
