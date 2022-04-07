using System;

namespace Massiv3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int minimumValue = 1;
            int maximumValue = 100;
            int maximumArrayLength = 30;

            int[] array = new int[maximumArrayLength];

            for(int i=0;i<array.Length;i++ )
            {
                array[i] = random.Next(minimumValue, maximumValue);
            }

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n");
            int maximumCounter = 0;

            for(int i=0;i<array.Length;i++ )
            {

                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        maximumCounter++;
                        Console.Write("Максимум №" + maximumCounter + " = " + array[i] + "\n");
                    }

                } else if (i == array.Length - 1)
                {

                    if (array[i] > array[i - 1])
                    {
                        maximumCounter++;
                        Console.Write("Максимум №" + maximumCounter + " = " + array[i] + "\n");
                    }

                }else
                 { 

                    if (array[i]>array[i+1]&array[i]>array[i-1])
                    {
                    maximumCounter++;
                    Console.Write("Максимум №" + maximumCounter + " = " + array[i]+"\n");
                    }

                 }
            }

            Console.ReadLine();
        }
    }
}
