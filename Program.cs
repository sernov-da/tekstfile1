//№2
using System;
using System.Collections.Specialized;
using System.IO;
class Program
{
    static void Main()
    {
        int count = 0;
        using (FileStream readOnlyStream = File.OpenRead(@"D:\laba2.2\2.txt"))
        {
            foreach (string animal in File.ReadAllLines(@"D:\laba2.2\2.txt"))
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}