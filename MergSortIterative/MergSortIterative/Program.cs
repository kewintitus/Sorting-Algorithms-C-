using System;
namespace MergSortIterative;
class Program
{
    static void Main(string[] args)
    {
        int n;
        int[] a = new int[20];
        Console.WriteLine("Enter the number of elements :");
        n= Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Enter value " + (i+1) + " : ");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Sort(a, n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] +" ");
            
        }
        Console.WriteLine();
    }
    public static void Sort(int[] a, int n)
    {
        int[] temp = new int[n];
        int size = 1;
        while (size <= n - 1)
        {
            Sort(a, temp, size, n);
            size *= 2;
        }
        

    }
    private static void Sort(int[] a, int[] temp, int size, int n)
    {
        int i, low1, up1, low2, up2;
        low1 = 0;
        

        while(low1 + size <= n - 1)
        {
            up1 = low1 + size - 1;
            low2 = up1 + 1;
            up2 = low2 + size - 1;

            if(up2 >= n)
            {
                up2 = n-1;
            }

            Merge(a, temp, low1, up1, low2, up2);



            low1 = up2 + 1;
        }
        for(i = low1; i<=n-1; i++)
        {
            temp[i] = a[i];
        }
        Copy(a, temp, n);

    }
    private static void Merge(int[] a, int[] temp, int low1, int up1, int low2, int up2)
    {
        int i = low1;
        int j = low2;
        int k = low1;
        while(i<=up1 && j <= up2)
        {
            if (a[i] <= a[j])
                temp[k++] = a[i++];
            else
                temp[k++] = a[j++];

        }
        while (i <= up1)
        {
            temp[k++] = a[i++];
        }
        while(j<= up2)
        {
            temp[k++] = a[j++];
        }
    }
    private static void Copy(int[] a, int[] temp, int n)
    {
        for(int i=0; i<n; i++)
        {
            a[i] = temp[i];
        }
    }
}