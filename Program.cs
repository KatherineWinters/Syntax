using System;

namespace SyntaxSugar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = $"{answer} is less than nine";
            }
            else
            {
                response = $"{answer} is greater than nine";
            }
            Console.WriteLine(response);
        }
    }
}
