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
            int lastElement = array.Length - 1;

            for (int i=0;i<array.Length;i++ )
            {
                array[i] = random.Next(minimumValue, maximumValue);
            }

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n");
            int maximumCounter = 0;
            
                if (array[0] > array[1])
                {
                    maximumCounter++;
                Console.Write("Максимум №" + maximumCounter + " = " + array[0] + "\n");
                }

            for (int i=1;i< lastElement; i++ )
            {

                    if (array[i]>array[i+1]&array[i]>array[i-1])
                    {
                    maximumCounter++;
                    Console.Write("Максимум №" + maximumCounter + " = " + array[i]+"\n");
                    }
            }
            
            int beforeLastElement = array.Length - 2;

                if (array[lastElement] > array[beforeLastElement])
                {
                    maximumCounter++;
                    Console.Write("Максимум №" + maximumCounter + " = " + array[lastElement] + "\n");
                }

            Console.ReadLine();
        }
    }
}
