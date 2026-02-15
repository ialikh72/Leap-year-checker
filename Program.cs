using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter year:");
        int year = int.Parse(Console.ReadLine());
        if(year%4==0 && year%100!=0 ||(year%400!=0))
        {
            Console.WriteLine("year is leap....");
        }
        else
            {
            Console.WriteLine("year is not leap....");
        }
    }
}
