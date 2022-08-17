using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Node temp, p;
            int i, n, data;
            Console.WriteLine("Enter no of elements in list");
            n=Convert.ToInt32(Console.ReadLine());
            Node start = null;
            for(i=1; i <= n; i++)
            {
                Console.Write("Enter element" + i + " : ");
                data = Convert.ToInt32(Console.ReadLine());
                temp = new Node(data);
                if(start == null)
                {
                    start = temp;
                }
                else
                {
                    p = start;
                    while(p.link != null)
                    {
                        p = p.link;
                    }
                    p.link = temp;
                }
            }
            start = Sort(start);
            Console.WriteLine("Sorted list");
            p = start;
            while(p!= null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public static Node Sort(Node start)
        {
            Node[] rear = new Node[10];
            Node[] front = new Node[10];
            int leastSigPos = 1;
            int mostSigPos = DigitsInLargest(start);
            int i, dig;
            Node p;
           for(int k=leastSigPos; k<=mostSigPos; k++)
            {
                for (i = 0; i <= 9; i++)
                {
                    rear[i] = null;
                    front[i] = null;

                }
                for(p=start; p!=null;p = p.link)
                {
                    dig = Digit(p.info,k);
                    if (front[dig] == null)
                    {
                        front[dig] = p;
                    }
                    else
                    {
                        rear[dig].link = p;
                    }
                    rear[dig] = p;
                }
                i = 0;
                while (front[i] == null)
                    i++;
                start = front[i];
                while (i <= 8)
                {
                    if (rear[i+1]!=null)
                        rear[i].link = front[i+1];
                    else
                        rear[i+1] = rear[i];
                    i++;
                }
                rear[9].link = null;
            }
            return start;
        }
        public static int DigitsInLargest(Node start)
        {
            int large = 0;
            Node p = start;
            
                while (p != null)
                {
                    if (p.info > large)
                        large = p.info;
                    p = p.link;
                }
                int nDigits = 0;
                while (large != 0)
                {
                    nDigits++;
                    large /= 10;
                }
                return nDigits;
            
        }
        public static int Digit(int n, int k)
        {
            int d = 0, i;
            for (i = 1; i <= k; i++)
            {
                d = n % 10;
                n/= 10;
            }
            return d;   
        }
    }

}
