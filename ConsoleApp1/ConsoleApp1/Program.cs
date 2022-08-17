using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, flag=0;
            
            
            n = Convert.ToInt32(Console.ReadLine());
            char[] inputArray = new char[n];
            for (int i = 0; i < n; i++)
            {
                inputArray[i] = Convert.ToChar(Console.Read());
            }
            for(int i=0; i<n; i++)
            {
                if (inputArray[i] == 'H' && inputArray[i + 1] == 'H')
                    flag = 1;
                else
                {
                    if (inputArray[i] == '.')
                    {
                        inputArray[i] = 'B';
                    }
                }
            }
            if (flag == 1)
                Console.WriteLine("NO");
            else
            {
                Console.WriteLine("YES");
                string str = GetString(inputArray);
                Console.WriteLine(str);

            }
                

        }
        private static string GetString(char[] str)
        {
            string s = new string(str);
            return s;
        }

    }

}