using System;
namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[20];
            Console.Write("Enter no of elements:");
            n=Convert.ToInt32(Console.ReadLine()); 

            for(i=1;i<=n; i++)
            {
                Console.Write("Enter element" + (i) +" : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(a, n);
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i]+ " ");

            }
            Console.WriteLine();
        }
        public static void Sort(int[] a, int n)
        {

            BuilddHeap_BottomUp(a, n);

            #region Displays the heap
            for(int i = 1; i<=n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            #endregion


            int maxvalue;
            while (n > 1)
            {
                maxvalue = a[1];
                a[1] = a[n];
                a[n] = maxvalue;
                n--;
                Heap_RestoreDown(1,a,n);
            }
        }
        public static void BuilddHeap_BottomUp(int[] a, int n)
        {
            int i;
            for(i=n/2; i>=1; i--)
            {
                Heap_RestoreDown(i, a, n);
            }

        }
        public static void Heap_RestoreDown(int i, int[] a, int n)
        {
            int k = a[i];
            int lchild = 2 * i, rchild = lchild + 1;

            while (rchild <= n)
            {
                if (k >= a[rchild] && k >= a[lchild])
                {
                    a[i] = k;
                    return;
                }
                 else if (a[lchild] > a[rchild])
                {
                    a[i] = a[lchild];
                    i = lchild;
                }
                else
                {
                    a[i] = a[rchild];
                    i = rchild;

                }
                lchild = 2 * i;
                rchild = lchild + 1;

            }
            if(lchild == n && k<= a[lchild])
            {
                a[i] = a[lchild];
                i = lchild;
            }
            a[i] = k;

        }

    }

}